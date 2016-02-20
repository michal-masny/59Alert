using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace _59Alert
{
    public partial class CallHistory : Form
    {
        public List<CallItem> CallList;
        public string FolderPath;
        public const string FolderPathEnding = @"\Five9\Logs\env001.atl.five9.com";
        public const string LogFileName = "adapter.log";
        public string LogFilePath;
        public CallHistory()
        {
            InitializeComponent();
            CallList = new List<CallItem>();
            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + FolderPathEnding;
            LogFilePath = FolderPath + "\\" + LogFileName;
            FileStream LogStream = new FileStream(LogFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader LogStreamReader = new StreamReader(LogStream);
            string line = "";
            string time = "";
            string previousnumber = "";
            string number = "";
            string queue = "";
            while(!LogStreamReader.EndOfStream)
            {
                line = LogStreamReader.ReadLine();
                if (line.Contains("RINGING") && line.Contains("Sending to model"))
                {
                    Match regexnumber = Regex.Match(line, @"number"":""(\d)+");
                    previousnumber = number;
                    number = regexnumber.Value.Remove(0,9);
                    time = line.Substring(0, (line.IndexOf(",")));
                    Match regexqueue = Regex.Match(line, @"campaignName"":""[^""]+");
                    queue = regexqueue.Value.Remove(0,15);
                    CallItem callitem = new CallItem(time, number, queue);
                    if (!String.IsNullOrEmpty(previousnumber) && number == previousnumber)
                        CallList.RemoveAt(CallList.Count - 1);
                    CallList.Add(callitem);
                }
            }
            CallList.Reverse();
        }

        private void dgvCallHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CallHistory_Load(object sender, EventArgs e)
        {
            dgvCallHistory.AutoGenerateColumns = true;
            dgvCallHistory.DataSource = CallList;
            dgvCallHistory.AutoResizeColumns();
        }
    }

    public class CallItem
    {
        public string Time { get; set; }
        public string Number { get; set; }
        public string Queue { get; set; }

        public CallItem(string time, string number, string queue)
        {
            Time = time;
            Number = number;
            Queue = queue;
        }
    }
}

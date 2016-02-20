namespace _59Alert
{
    partial class CallHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallHistory));
            this.dgvCallHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCallHistory
            // 
            this.dgvCallHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCallHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvCallHistory.Name = "dgvCallHistory";
            this.dgvCallHistory.Size = new System.Drawing.Size(334, 262);
            this.dgvCallHistory.TabIndex = 0;
            this.dgvCallHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCallHistory_CellContentClick);
            // 
            // CallHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.dgvCallHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CallHistory";
            this.Text = "Call History";
            this.Load += new System.EventHandler(this.CallHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCallHistory;
    }
}


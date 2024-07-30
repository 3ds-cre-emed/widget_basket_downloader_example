namespace ProductDownloader
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.btnImportTicket = new System.Windows.Forms.Button();
            this.myNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.myFileOpener = new System.Windows.Forms.OpenFileDialog();
            this.txtTicketPath = new System.Windows.Forms.TextBox();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.myProgress = new System.Windows.Forms.ProgressBar();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportTicket
            // 
            this.btnImportTicket.Location = new System.Drawing.Point(511, 12);
            this.btnImportTicket.Name = "btnImportTicket";
            this.btnImportTicket.Size = new System.Drawing.Size(131, 66);
            this.btnImportTicket.TabIndex = 0;
            this.btnImportTicket.Text = "Import Download Ticket";
            this.btnImportTicket.UseVisualStyleBackColor = true;
            this.btnImportTicket.Click += new System.EventHandler(this.btnImportTicket_Click);
            // 
            // myNotifier
            // 
            this.myNotifier.Visible = true;
            // 
            // myFileOpener
            // 
            this.myFileOpener.FileName = "*.json";
            // 
            // txtTicketPath
            // 
            this.txtTicketPath.AllowDrop = true;
            this.txtTicketPath.Location = new System.Drawing.Point(12, 34);
            this.txtTicketPath.Name = "txtTicketPath";
            this.txtTicketPath.ReadOnly = true;
            this.txtTicketPath.Size = new System.Drawing.Size(493, 22);
            this.txtTicketPath.TabIndex = 1;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartDownload.Enabled = false;
            this.btnStartDownload.Location = new System.Drawing.Point(204, 182);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(255, 91);
            this.btnStartDownload.TabIndex = 2;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = false;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // myProgress
            // 
            this.myProgress.Location = new System.Drawing.Point(12, 126);
            this.myProgress.Maximum = 113;
            this.myProgress.Name = "myProgress";
            this.myProgress.Size = new System.Drawing.Size(630, 37);
            this.myProgress.Step = 1;
            this.myProgress.TabIndex = 3;
            this.myProgress.Visible = false;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(24, 182);
            this.myLabel.MaximumSize = new System.Drawing.Size(600, 80);
            this.myLabel.MinimumSize = new System.Drawing.Size(0, 80);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(0, 80);
            this.myLabel.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 285);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myProgress);
            this.Controls.Add(this.btnStartDownload);
            this.Controls.Add(this.txtTicketPath);
            this.Controls.Add(this.btnImportTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Product Download Monitor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportTicket;
        private System.Windows.Forms.NotifyIcon myNotifier;
        private System.Windows.Forms.OpenFileDialog myFileOpener;
        private System.Windows.Forms.TextBox txtTicketPath;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.ProgressBar myProgress;
        private System.Windows.Forms.Label myLabel;
    }
}


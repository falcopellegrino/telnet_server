namespace TelnetServer
{
    partial class TelnetServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblHost = new System.Windows.Forms.Label();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.LblPort = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblHost
            // 
            this.LblHost.AutoSize = true;
            this.LblHost.Location = new System.Drawing.Point(9, 15);
            this.LblHost.Name = "LblHost";
            this.LblHost.Size = new System.Drawing.Size(37, 17);
            this.LblHost.TabIndex = 3;
            this.LblHost.Text = "Host";
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(65, 12);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(100, 22);
            this.TxtHost.TabIndex = 4;
            this.TxtHost.Text = "127.0.0.1";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(213, 12);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(100, 22);
            this.TxtPort.TabIndex = 6;
            this.TxtPort.Text = "10000";
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.Location = new System.Drawing.Point(173, 15);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(34, 17);
            this.LblPort.TabIndex = 5;
            this.LblPort.Text = "Port";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(319, 9);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(106, 29);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(438, 9);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(106, 29);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(12, 40);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.ReadOnly = true;
            this.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtStatus.Size = new System.Drawing.Size(532, 321);
            this.TxtStatus.TabIndex = 9;
            // 
            // TelnetServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 373);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.LblPort);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.LblHost);
            this.Name = "TelnetServer";
            this.Text = "TelnetServer";
            this.Load += new System.EventHandler(this.TelnetServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHost;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label LblPort;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox TxtStatus;
    }
}


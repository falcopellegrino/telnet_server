namespace TelnetClient
{
    partial class Form1
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.LblPort = new System.Windows.Forms.Label();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.LblHost = new System.Windows.Forms.Label();
            this.TxtMessages = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(326, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(106, 29);
            this.BtnConnect.TabIndex = 12;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(220, 15);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(100, 22);
            this.TxtPort.TabIndex = 11;
            this.TxtPort.Text = "10000";
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.Location = new System.Drawing.Point(180, 18);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(34, 17);
            this.LblPort.TabIndex = 10;
            this.LblPort.Text = "Port";
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(72, 15);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(100, 22);
            this.TxtHost.TabIndex = 9;
            this.TxtHost.Text = "127.0.0.1";
            // 
            // LblHost
            // 
            this.LblHost.AutoSize = true;
            this.LblHost.Location = new System.Drawing.Point(16, 18);
            this.LblHost.Name = "LblHost";
            this.LblHost.Size = new System.Drawing.Size(37, 17);
            this.LblHost.TabIndex = 8;
            this.LblHost.Text = "Host";
            // 
            // TxtMessages
            // 
            this.TxtMessages.Enabled = false;
            this.TxtMessages.Location = new System.Drawing.Point(12, 70);
            this.TxtMessages.Multiline = true;
            this.TxtMessages.Name = "TxtMessages";
            this.TxtMessages.Size = new System.Drawing.Size(522, 95);
            this.TxtMessages.TabIndex = 13;
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(428, 171);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(106, 29);
            this.BtnSend.TabIndex = 14;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(19, 248);
            this.TxtStatus.Multiline = true;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.ReadOnly = true;
            this.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtStatus.Size = new System.Drawing.Size(515, 118);
            this.TxtStatus.TabIndex = 15;
            // 
            // BtnClose
            // 
            this.BtnClose.Enabled = false;
            this.BtnClose.Location = new System.Drawing.Point(438, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(96, 29);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Msg to send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Msg sent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessages);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.LblPort);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.LblHost);
            this.Name = "Form1";
            this.Text = "TelnetClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label LblPort;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label LblHost;
        private System.Windows.Forms.TextBox TxtMessages;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


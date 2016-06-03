namespace NetZombie
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.lstZombies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSockets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comCommand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPackets = new System.Windows.Forms.TextBox();
            this.btnCommandStart = new System.Windows.Forms.Button();
            this.btnCommandStop = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnBuilder});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(411, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(37, 20);
            this.btnFile.Text = "File";
            // 
            // btnBuilder
            // 
            this.btnBuilder.Name = "btnBuilder";
            this.btnBuilder.Size = new System.Drawing.Size(56, 20);
            this.btnBuilder.Text = "Builder";
            this.btnBuilder.Click += new System.EventHandler(this.btnBuilder_Click);
            // 
            // lstZombies
            // 
            this.lstZombies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstZombies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZombies.FullRowSelect = true;
            this.lstZombies.Location = new System.Drawing.Point(0, 27);
            this.lstZombies.Name = "lstZombies";
            this.lstZombies.Size = new System.Drawing.Size(411, 138);
            this.lstZombies.TabIndex = 1;
            this.lstZombies.UseCompatibleStateImageBehavior = false;
            this.lstZombies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hosts Online: 0";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version:";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status:";
            this.columnHeader3.Width = 152;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(411, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(5, 184);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(135, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "IP GOES HERE.";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(146, 184);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(58, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "80";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sockets:";
            // 
            // txtSockets
            // 
            this.txtSockets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSockets.Location = new System.Drawing.Point(207, 184);
            this.txtSockets.Name = "txtSockets";
            this.txtSockets.Size = new System.Drawing.Size(58, 20);
            this.txtSockets.TabIndex = 8;
            this.txtSockets.Text = "30";
            this.txtSockets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command:";
            // 
            // comCommand
            // 
            this.comCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCommand.FormattingEnabled = true;
            this.comCommand.Items.AddRange(new object[] {
            "UDP",
            "TCP",
            "Slowloris",
            "SYN"});
            this.comCommand.Location = new System.Drawing.Point(268, 184);
            this.comCommand.Name = "comCommand";
            this.comCommand.Size = new System.Drawing.Size(68, 21);
            this.comCommand.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Packets:";
            // 
            // txtPackets
            // 
            this.txtPackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackets.Location = new System.Drawing.Point(339, 184);
            this.txtPackets.Name = "txtPackets";
            this.txtPackets.Size = new System.Drawing.Size(67, 20);
            this.txtPackets.TabIndex = 12;
            this.txtPackets.Text = "2000";
            this.txtPackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCommandStart
            // 
            this.btnCommandStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.btnCommandStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommandStart.Location = new System.Drawing.Point(5, 210);
            this.btnCommandStart.Name = "btnCommandStart";
            this.btnCommandStart.Size = new System.Drawing.Size(199, 23);
            this.btnCommandStart.TabIndex = 13;
            this.btnCommandStart.Text = "Send Command: Start";
            this.btnCommandStart.UseVisualStyleBackColor = false;
            // 
            // btnCommandStop
            // 
            this.btnCommandStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCommandStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommandStop.Location = new System.Drawing.Point(207, 211);
            this.btnCommandStop.Name = "btnCommandStop";
            this.btnCommandStop.Size = new System.Drawing.Size(199, 23);
            this.btnCommandStop.TabIndex = 13;
            this.btnCommandStop.Text = "Send Command: Stop";
            this.btnCommandStop.UseVisualStyleBackColor = false;
            this.btnCommandStop.Click += new System.EventHandler(this.btnCommandStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.btnCommandStop);
            this.Controls.Add(this.btnCommandStart);
            this.Controls.Add(this.txtPackets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSockets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lstZombies);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ListView lstZombies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSockets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPackets;
        private System.Windows.Forms.Button btnCommandStart;
        private System.Windows.Forms.Button btnCommandStop;
        private System.Windows.Forms.ToolStripMenuItem btnBuilder;
    }
}


namespace SSH_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTextTestSingleIP = new System.Windows.Forms.Label();
            this.txtTestSingleIP = new System.Windows.Forms.TextBox();
            this.lblInternetIP = new System.Windows.Forms.Label();
            this.ltvIPsOnNetwork = new System.Windows.Forms.ListView();
            this.btnCheckNetworkForIPs = new System.Windows.Forms.Button();
            this.btnCheckOneIP = new System.Windows.Forms.Button();
            this.lblHowManyIPs = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSingleIP = new System.Windows.Forms.Label();
            this.btnSSH = new System.Windows.Forms.Button();
            this.lblLoginWith = new System.Windows.Forms.Label();
            this.ckbSSH = new System.Windows.Forms.CheckBox();
            this.lblCheckFor = new System.Windows.Forms.Label();
            this.lblSingleSSH = new System.Windows.Forms.Label();
            this.txtPortsOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortsTwo = new System.Windows.Forms.TextBox();
            this.ckbFTP20 = new System.Windows.Forms.CheckBox();
            this.ckbFTP21 = new System.Windows.Forms.CheckBox();
            this.ckbTelnet = new System.Windows.Forms.CheckBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextTestSingleIP
            // 
            this.lblTextTestSingleIP.AutoSize = true;
            this.lblTextTestSingleIP.Location = new System.Drawing.Point(43, 17);
            this.lblTextTestSingleIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextTestSingleIP.Name = "lblTextTestSingleIP";
            this.lblTextTestSingleIP.Size = new System.Drawing.Size(108, 20);
            this.lblTextTestSingleIP.TabIndex = 0;
            this.lblTextTestSingleIP.Text = "Test a Single IP";
            // 
            // txtTestSingleIP
            // 
            this.txtTestSingleIP.Location = new System.Drawing.Point(159, 14);
            this.txtTestSingleIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTestSingleIP.Name = "txtTestSingleIP";
            this.txtTestSingleIP.Size = new System.Drawing.Size(132, 27);
            this.txtTestSingleIP.TabIndex = 1;
            // 
            // lblInternetIP
            // 
            this.lblInternetIP.AutoSize = true;
            this.lblInternetIP.Location = new System.Drawing.Point(13, 372);
            this.lblInternetIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternetIP.Name = "lblInternetIP";
            this.lblInternetIP.Size = new System.Drawing.Size(24, 20);
            this.lblInternetIP.TabIndex = 2;
            this.lblInternetIP.Text = "IP:";
            // 
            // ltvIPsOnNetwork
            // 
            this.ltvIPsOnNetwork.Location = new System.Drawing.Point(17, 80);
            this.ltvIPsOnNetwork.Name = "ltvIPsOnNetwork";
            this.ltvIPsOnNetwork.Size = new System.Drawing.Size(412, 148);
            this.ltvIPsOnNetwork.TabIndex = 3;
            this.ltvIPsOnNetwork.UseCompatibleStateImageBehavior = false;
            this.ltvIPsOnNetwork.SelectedIndexChanged += new System.EventHandler(this.ltvIPsOnNetwork_SelectedIndexChanged);
            // 
            // btnCheckNetworkForIPs
            // 
            this.btnCheckNetworkForIPs.Location = new System.Drawing.Point(17, 295);
            this.btnCheckNetworkForIPs.Name = "btnCheckNetworkForIPs";
            this.btnCheckNetworkForIPs.Size = new System.Drawing.Size(412, 31);
            this.btnCheckNetworkForIPs.TabIndex = 4;
            this.btnCheckNetworkForIPs.Text = "Check Network For IPs";
            this.btnCheckNetworkForIPs.UseVisualStyleBackColor = true;
            this.btnCheckNetworkForIPs.Click += new System.EventHandler(this.btnCheckNetworkForIPs_Click);
            // 
            // btnCheckOneIP
            // 
            this.btnCheckOneIP.Location = new System.Drawing.Point(298, 12);
            this.btnCheckOneIP.Name = "btnCheckOneIP";
            this.btnCheckOneIP.Size = new System.Drawing.Size(99, 31);
            this.btnCheckOneIP.TabIndex = 5;
            this.btnCheckOneIP.Text = "Check";
            this.btnCheckOneIP.UseVisualStyleBackColor = true;
            this.btnCheckOneIP.Click += new System.EventHandler(this.btnCheckOneIP_Click);
            // 
            // lblHowManyIPs
            // 
            this.lblHowManyIPs.AutoSize = true;
            this.lblHowManyIPs.Location = new System.Drawing.Point(13, 352);
            this.lblHowManyIPs.Name = "lblHowManyIPs";
            this.lblHowManyIPs.Size = new System.Drawing.Size(0, 20);
            this.lblHowManyIPs.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(43, 57);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // lblSingleIP
            // 
            this.lblSingleIP.AutoSize = true;
            this.lblSingleIP.Location = new System.Drawing.Point(43, 37);
            this.lblSingleIP.Name = "lblSingleIP";
            this.lblSingleIP.Size = new System.Drawing.Size(24, 20);
            this.lblSingleIP.TabIndex = 8;
            this.lblSingleIP.Text = "IP:";
            // 
            // btnSSH
            // 
            this.btnSSH.Enabled = false;
            this.btnSSH.Location = new System.Drawing.Point(349, 332);
            this.btnSSH.Name = "btnSSH";
            this.btnSSH.Size = new System.Drawing.Size(80, 28);
            this.btnSSH.TabIndex = 9;
            this.btnSSH.Text = "SSH";
            this.btnSSH.UseVisualStyleBackColor = true;
            this.btnSSH.Click += new System.EventHandler(this.btnSSH_Click);
            // 
            // lblLoginWith
            // 
            this.lblLoginWith.AutoSize = true;
            this.lblLoginWith.Location = new System.Drawing.Point(13, 332);
            this.lblLoginWith.Name = "lblLoginWith";
            this.lblLoginWith.Size = new System.Drawing.Size(84, 20);
            this.lblLoginWith.TabIndex = 10;
            this.lblLoginWith.Text = "Login With:";
            // 
            // ckbSSH
            // 
            this.ckbSSH.AutoSize = true;
            this.ckbSSH.Location = new System.Drawing.Point(253, 265);
            this.ckbSSH.Name = "ckbSSH";
            this.ckbSSH.Size = new System.Drawing.Size(55, 24);
            this.ckbSSH.TabIndex = 11;
            this.ckbSSH.Text = "SSH";
            this.ckbSSH.UseVisualStyleBackColor = true;
            // 
            // lblCheckFor
            // 
            this.lblCheckFor.AutoSize = true;
            this.lblCheckFor.Location = new System.Drawing.Point(13, 235);
            this.lblCheckFor.Name = "lblCheckFor";
            this.lblCheckFor.Size = new System.Drawing.Size(76, 20);
            this.lblCheckFor.TabIndex = 12;
            this.lblCheckFor.Text = "Check For:";
            // 
            // lblSingleSSH
            // 
            this.lblSingleSSH.AutoSize = true;
            this.lblSingleSSH.Location = new System.Drawing.Point(294, 46);
            this.lblSingleSSH.Name = "lblSingleSSH";
            this.lblSingleSSH.Size = new System.Drawing.Size(39, 20);
            this.lblSingleSSH.TabIndex = 13;
            this.lblSingleSSH.Text = "SSH:";
            // 
            // txtPortsOne
            // 
            this.txtPortsOne.Location = new System.Drawing.Point(142, 233);
            this.txtPortsOne.Name = "txtPortsOne";
            this.txtPortsOne.Size = new System.Drawing.Size(39, 27);
            this.txtPortsOne.TabIndex = 14;
            this.txtPortsOne.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "-";
            // 
            // txtPortsTwo
            // 
            this.txtPortsTwo.Location = new System.Drawing.Point(208, 233);
            this.txtPortsTwo.Name = "txtPortsTwo";
            this.txtPortsTwo.Size = new System.Drawing.Size(39, 27);
            this.txtPortsTwo.TabIndex = 17;
            this.txtPortsTwo.Text = "255";
            // 
            // ckbFTP20
            // 
            this.ckbFTP20.AutoSize = true;
            this.ckbFTP20.Location = new System.Drawing.Point(253, 235);
            this.ckbFTP20.Name = "ckbFTP20";
            this.ckbFTP20.Size = new System.Drawing.Size(81, 24);
            this.ckbFTP20.TabIndex = 18;
            this.ckbFTP20.Text = "FTP (20)";
            this.ckbFTP20.UseVisualStyleBackColor = true;
            // 
            // ckbFTP21
            // 
            this.ckbFTP21.AutoSize = true;
            this.ckbFTP21.Location = new System.Drawing.Point(340, 233);
            this.ckbFTP21.Name = "ckbFTP21";
            this.ckbFTP21.Size = new System.Drawing.Size(81, 24);
            this.ckbFTP21.TabIndex = 19;
            this.ckbFTP21.Text = "FTP (21)";
            this.ckbFTP21.UseVisualStyleBackColor = true;
            // 
            // ckbTelnet
            // 
            this.ckbTelnet.AutoSize = true;
            this.ckbTelnet.Location = new System.Drawing.Point(340, 265);
            this.ckbTelnet.Name = "ckbTelnet";
            this.ckbTelnet.Size = new System.Drawing.Size(98, 24);
            this.ckbTelnet.TabIndex = 20;
            this.ckbTelnet.Text = "Telnet (23)";
            this.ckbTelnet.UseVisualStyleBackColor = true;
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(17, 265);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(119, 27);
            this.txtHeader.TabIndex = 21;
            this.txtHeader.Text = "192.168.1.";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnCheckNetworkForIPs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 396);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.ckbTelnet);
            this.Controls.Add(this.ckbFTP21);
            this.Controls.Add(this.ckbFTP20);
            this.Controls.Add(this.txtPortsTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPortsOne);
            this.Controls.Add(this.lblSingleSSH);
            this.Controls.Add(this.lblCheckFor);
            this.Controls.Add(this.ckbSSH);
            this.Controls.Add(this.lblLoginWith);
            this.Controls.Add(this.btnSSH);
            this.Controls.Add(this.lblSingleIP);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHowManyIPs);
            this.Controls.Add(this.btnCheckOneIP);
            this.Controls.Add(this.btnCheckNetworkForIPs);
            this.Controls.Add(this.ltvIPsOnNetwork);
            this.Controls.Add(this.lblInternetIP);
            this.Controls.Add(this.txtTestSingleIP);
            this.Controls.Add(this.lblTextTestSingleIP);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Port Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextTestSingleIP;
        private System.Windows.Forms.TextBox txtTestSingleIP;
        private System.Windows.Forms.Label lblInternetIP;
        private System.Windows.Forms.ListView ltvIPsOnNetwork;
        private System.Windows.Forms.Button btnCheckNetworkForIPs;
        private System.Windows.Forms.Button btnCheckOneIP;
        private System.Windows.Forms.Label lblHowManyIPs;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSingleIP;
        private System.Windows.Forms.Button btnSSH;
        private System.Windows.Forms.Label lblLoginWith;
        private System.Windows.Forms.CheckBox ckbSSH;
        private System.Windows.Forms.Label lblCheckFor;
        private System.Windows.Forms.Label lblSingleSSH;
        private System.Windows.Forms.TextBox txtPortsOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortsTwo;
        private System.Windows.Forms.CheckBox ckbFTP20;
        private System.Windows.Forms.CheckBox ckbFTP21;
        private System.Windows.Forms.CheckBox ckbTelnet;
        private System.Windows.Forms.TextBox txtHeader;
    }
}


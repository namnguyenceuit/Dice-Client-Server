namespace DiceServer
{
    partial class DiceServer
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
            this.clientCommunicationtb = new System.Windows.Forms.TextBox();
            this.connectionManagertb = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.porttb = new System.Windows.Forms.TextBox();
            this.ipAdtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientCommunicationtb
            // 
            this.clientCommunicationtb.Location = new System.Drawing.Point(13, 231);
            this.clientCommunicationtb.Multiline = true;
            this.clientCommunicationtb.Name = "clientCommunicationtb";
            this.clientCommunicationtb.ReadOnly = true;
            this.clientCommunicationtb.Size = new System.Drawing.Size(264, 84);
            this.clientCommunicationtb.TabIndex = 54;
            // 
            // connectionManagertb
            // 
            this.connectionManagertb.Location = new System.Drawing.Point(12, 103);
            this.connectionManagertb.Multiline = true;
            this.connectionManagertb.Name = "connectionManagertb";
            this.connectionManagertb.ReadOnly = true;
            this.connectionManagertb.Size = new System.Drawing.Size(265, 81);
            this.connectionManagertb.TabIndex = 53;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(203, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 49);
            this.btnStart.TabIndex = 52;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // porttb
            // 
            this.porttb.Location = new System.Drawing.Point(69, 38);
            this.porttb.Name = "porttb";
            this.porttb.Size = new System.Drawing.Size(128, 20);
            this.porttb.TabIndex = 51;
            this.porttb.Text = "13000";
            // 
            // ipAdtb
            // 
            this.ipAdtb.Location = new System.Drawing.Point(69, 9);
            this.ipAdtb.Name = "ipAdtb";
            this.ipAdtb.Size = new System.Drawing.Size(128, 20);
            this.ipAdtb.TabIndex = 50;
            this.ipAdtb.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Quản lí giao tiếp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Quản lí kết nối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Địa chỉ IP";
            // 
            // DiceServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 326);
            this.Controls.Add(this.clientCommunicationtb);
            this.Controls.Add(this.connectionManagertb);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.porttb);
            this.Controls.Add(this.ipAdtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiceServer";
            this.Text = "DiceServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiceServer_FormClosing);
            this.Load += new System.EventHandler(this.DiceServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientCommunicationtb;
        private System.Windows.Forms.TextBox connectionManagertb;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox porttb;
        private System.Windows.Forms.TextBox ipAdtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


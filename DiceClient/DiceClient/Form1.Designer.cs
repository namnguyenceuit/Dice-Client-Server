namespace DiceClient
{
    partial class DiceClient
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
            this.btnBounce = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.score2tb = new System.Windows.Forms.TextBox();
            this.score1tb = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.porttb = new System.Windows.Forms.TextBox();
            this.ipAdtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneytb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBounce
            // 
            this.btnBounce.Location = new System.Drawing.Point(233, 88);
            this.btnBounce.Name = "btnBounce";
            this.btnBounce.Size = new System.Drawing.Size(75, 57);
            this.btnBounce.TabIndex = 63;
            this.btnBounce.Text = "Tung";
            this.btnBounce.UseVisualStyleBackColor = true;
            this.btnBounce.Click += new System.EventHandler(this.btnBounce_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Điểm đối thủ";
            // 
            // score2tb
            // 
            this.score2tb.Location = new System.Drawing.Point(96, 125);
            this.score2tb.Name = "score2tb";
            this.score2tb.Size = new System.Drawing.Size(128, 20);
            this.score2tb.TabIndex = 61;
            // 
            // score1tb
            // 
            this.score1tb.Location = new System.Drawing.Point(96, 90);
            this.score1tb.Name = "score1tb";
            this.score1tb.Size = new System.Drawing.Size(128, 20);
            this.score1tb.TabIndex = 59;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(233, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 49);
            this.btnConnect.TabIndex = 58;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // porttb
            // 
            this.porttb.Location = new System.Drawing.Point(96, 41);
            this.porttb.Name = "porttb";
            this.porttb.Size = new System.Drawing.Size(128, 20);
            this.porttb.TabIndex = 57;
            this.porttb.Text = "13000";
            // 
            // ipAdtb
            // 
            this.ipAdtb.Location = new System.Drawing.Point(96, 12);
            this.ipAdtb.Name = "ipAdtb";
            this.ipAdtb.Size = new System.Drawing.Size(128, 20);
            this.ipAdtb.TabIndex = 56;
            this.ipAdtb.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Điểm của mình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Địa chỉ IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Số tiền";
            // 
            // moneytb
            // 
            this.moneytb.Location = new System.Drawing.Point(96, 165);
            this.moneytb.Name = "moneytb";
            this.moneytb.ReadOnly = true;
            this.moneytb.Size = new System.Drawing.Size(212, 20);
            this.moneytb.TabIndex = 60;
            this.moneytb.Text = "1000";
            // 
            // DiceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.btnBounce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.score2tb);
            this.Controls.Add(this.moneytb);
            this.Controls.Add(this.score1tb);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.porttb);
            this.Controls.Add(this.ipAdtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiceClient";
            this.Text = "DiceClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiceClient_FormClosing);
            this.Load += new System.EventHandler(this.DiceClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBounce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox score2tb;
        private System.Windows.Forms.TextBox score1tb;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox porttb;
        private System.Windows.Forms.TextBox ipAdtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moneytb;
    }
}


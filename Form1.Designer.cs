namespace FWTABdecoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtTAB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetInfo2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSRC = new System.Windows.Forms.TextBox();
            this.txtDST = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSRCPORT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDSTPORT = new System.Windows.Forms.TextBox();
            this.txtPROTO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRULE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSESSION = new System.Windows.Forms.TextBox();
            this.txtCMD = new System.Windows.Forms.TextBox();
            this.txtKill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Enter IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(33, 41);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 23);
            this.txtIP.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(179, 42);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(130, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Create Command ->";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtTAB
            // 
            this.txtTAB.Location = new System.Drawing.Point(12, 92);
            this.txtTAB.Multiline = true;
            this.txtTAB.Name = "txtTAB";
            this.txtTAB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTAB.Size = new System.Drawing.Size(742, 125);
            this.txtTAB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "2. Use this command in expert shell to list  active sessions";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGetInfo2
            // 
            this.btnGetInfo2.Location = new System.Drawing.Point(12, 228);
            this.btnGetInfo2.Name = "btnGetInfo2";
            this.btnGetInfo2.Size = new System.Drawing.Size(147, 23);
            this.btnGetInfo2.TabIndex = 5;
            this.btnGetInfo2.Text = "Get Information!";
            this.btnGetInfo2.UseVisualStyleBackColor = true;
            this.btnGetInfo2.Click += new System.EventHandler(this.btnGetInfo2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direction:";
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(12, 289);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(140, 23);
            this.txtDirection.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "SRC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "DST";
            // 
            // txtSRC
            // 
            this.txtSRC.Location = new System.Drawing.Point(12, 342);
            this.txtSRC.Name = "txtSRC";
            this.txtSRC.Size = new System.Drawing.Size(140, 23);
            this.txtSRC.TabIndex = 2;
            this.txtSRC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDST
            // 
            this.txtDST.Location = new System.Drawing.Point(304, 342);
            this.txtDST.Name = "txtDST";
            this.txtDST.Size = new System.Drawing.Size(140, 23);
            this.txtDST.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "SRCPORT";
            // 
            // txtSRCPORT
            // 
            this.txtSRCPORT.Location = new System.Drawing.Point(158, 342);
            this.txtSRCPORT.Name = "txtSRCPORT";
            this.txtSRCPORT.Size = new System.Drawing.Size(140, 23);
            this.txtSRCPORT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "DSTPORT";
            // 
            // txtDSTPORT
            // 
            this.txtDSTPORT.Location = new System.Drawing.Point(450, 342);
            this.txtDSTPORT.Name = "txtDSTPORT";
            this.txtDSTPORT.Size = new System.Drawing.Size(140, 23);
            this.txtDSTPORT.TabIndex = 2;
            // 
            // txtPROTO
            // 
            this.txtPROTO.Location = new System.Drawing.Point(596, 342);
            this.txtPROTO.Name = "txtPROTO";
            this.txtPROTO.Size = new System.Drawing.Size(140, 23);
            this.txtPROTO.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "PROTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "RULE";
            // 
            // txtRULE
            // 
            this.txtRULE.Location = new System.Drawing.Point(10, 404);
            this.txtRULE.Name = "txtRULE";
            this.txtRULE.Size = new System.Drawing.Size(140, 23);
            this.txtRULE.TabIndex = 2;
            this.txtRULE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "SESSIONSTART";
            // 
            // txtSESSION
            // 
            this.txtSESSION.Location = new System.Drawing.Point(154, 404);
            this.txtSESSION.Name = "txtSESSION";
            this.txtSESSION.Size = new System.Drawing.Size(436, 23);
            this.txtSESSION.TabIndex = 2;
            // 
            // txtCMD
            // 
            this.txtCMD.Location = new System.Drawing.Point(315, 41);
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.Size = new System.Drawing.Size(398, 23);
            this.txtCMD.TabIndex = 2;
            // 
            // txtKill
            // 
            this.txtKill.Location = new System.Drawing.Point(10, 452);
            this.txtKill.Name = "txtKill";
            this.txtKill.Size = new System.Drawing.Size(726, 23);
            this.txtKill.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "4. Use this command in expert shell to kill this session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "3. Paste a single session in this box to retrieve its information";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKill);
            this.Controls.Add(this.txtCMD);
            this.Controls.Add(this.txtSESSION);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRULE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPROTO);
            this.Controls.Add(this.txtDSTPORT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSRCPORT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDST);
            this.Controls.Add(this.txtSRC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetInfo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTAB);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Check Point Session Table Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtTAB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetInfo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSRC;
        private System.Windows.Forms.TextBox txtDST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSRCPORT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDSTPORT;
        private System.Windows.Forms.TextBox txtPROTO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRULE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSESSION;
        private System.Windows.Forms.TextBox txtCMD;
        private System.Windows.Forms.TextBox txtKill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
    }
}


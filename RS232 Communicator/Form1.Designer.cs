namespace RS232_Communicator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.portButtonA = new System.Windows.Forms.Button();
            this.stopBoxA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityBoxA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recvTextA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudBoxA = new System.Windows.Forms.ComboBox();
            this.msgBoxA = new System.Windows.Forms.TextBox();
            this.sendButtonA = new System.Windows.Forms.Button();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.portButtonB = new System.Windows.Forms.Button();
            this.stopBoxB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parityBoxB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.recvTextB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comBoxB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.baudBoxB = new System.Windows.Forms.ComboBox();
            this.msgBoxB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sendButtonB = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.portButtonA);
            this.groupBoxA.Controls.Add(this.stopBoxA);
            this.groupBoxA.Controls.Add(this.label7);
            this.groupBoxA.Controls.Add(this.parityBoxA);
            this.groupBoxA.Controls.Add(this.label6);
            this.groupBoxA.Controls.Add(this.recvTextA);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.comBoxA);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.baudBoxA);
            this.groupBoxA.Controls.Add(this.msgBoxA);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.sendButtonA);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(360, 175);
            this.groupBoxA.TabIndex = 2;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Port A";
            // 
            // portButtonA
            // 
            this.portButtonA.Location = new System.Drawing.Point(258, 89);
            this.portButtonA.Name = "portButtonA";
            this.portButtonA.Size = new System.Drawing.Size(91, 23);
            this.portButtonA.TabIndex = 13;
            this.portButtonA.Text = "Connect";
            this.portButtonA.UseVisualStyleBackColor = true;
            this.portButtonA.Click += new System.EventHandler(this.connectButtonA_Click);
            // 
            // stopBoxA
            // 
            this.stopBoxA.FormattingEnabled = true;
            this.stopBoxA.Location = new System.Drawing.Point(65, 94);
            this.stopBoxA.Name = "stopBoxA";
            this.stopBoxA.Size = new System.Drawing.Size(121, 21);
            this.stopBoxA.Sorted = true;
            this.stopBoxA.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stop Bit:";
            // 
            // parityBoxA
            // 
            this.parityBoxA.FormattingEnabled = true;
            this.parityBoxA.Location = new System.Drawing.Point(65, 67);
            this.parityBoxA.Name = "parityBoxA";
            this.parityBoxA.Size = new System.Drawing.Size(121, 21);
            this.parityBoxA.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Parity:";
            // 
            // recvTextA
            // 
            this.recvTextA.AutoSize = true;
            this.recvTextA.Location = new System.Drawing.Point(68, 152);
            this.recvTextA.Name = "recvTextA";
            this.recvTextA.Size = new System.Drawing.Size(0, 13);
            this.recvTextA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Received:";
            // 
            // comBoxA
            // 
            this.comBoxA.FormattingEnabled = true;
            this.comBoxA.Location = new System.Drawing.Point(65, 13);
            this.comBoxA.Name = "comBoxA";
            this.comBoxA.Size = new System.Drawing.Size(121, 21);
            this.comBoxA.Sorted = true;
            this.comBoxA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Com Port:";
            // 
            // baudBoxA
            // 
            this.baudBoxA.FormattingEnabled = true;
            this.baudBoxA.Location = new System.Drawing.Point(65, 40);
            this.baudBoxA.Name = "baudBoxA";
            this.baudBoxA.Size = new System.Drawing.Size(121, 21);
            this.baudBoxA.TabIndex = 4;
            // 
            // msgBoxA
            // 
            this.msgBoxA.Location = new System.Drawing.Point(65, 121);
            this.msgBoxA.Name = "msgBoxA";
            this.msgBoxA.Size = new System.Drawing.Size(187, 20);
            this.msgBoxA.TabIndex = 3;
            // 
            // sendButtonA
            // 
            this.sendButtonA.Location = new System.Drawing.Point(258, 118);
            this.sendButtonA.Name = "sendButtonA";
            this.sendButtonA.Size = new System.Drawing.Size(91, 23);
            this.sendButtonA.TabIndex = 2;
            this.sendButtonA.Text = "Send Message";
            this.sendButtonA.UseVisualStyleBackColor = true;
            this.sendButtonA.Click += new System.EventHandler(this.sendButtonA_Click);
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.portButtonB);
            this.groupBoxB.Controls.Add(this.stopBoxB);
            this.groupBoxB.Controls.Add(this.label5);
            this.groupBoxB.Controls.Add(this.parityBoxB);
            this.groupBoxB.Controls.Add(this.label8);
            this.groupBoxB.Controls.Add(this.recvTextB);
            this.groupBoxB.Controls.Add(this.label10);
            this.groupBoxB.Controls.Add(this.comBoxB);
            this.groupBoxB.Controls.Add(this.label11);
            this.groupBoxB.Controls.Add(this.baudBoxB);
            this.groupBoxB.Controls.Add(this.msgBoxB);
            this.groupBoxB.Controls.Add(this.label12);
            this.groupBoxB.Controls.Add(this.sendButtonB);
            this.groupBoxB.Controls.Add(this.label13);
            this.groupBoxB.Location = new System.Drawing.Point(12, 193);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(360, 175);
            this.groupBoxB.TabIndex = 3;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Port B";
            // 
            // portButtonB
            // 
            this.portButtonB.Location = new System.Drawing.Point(256, 87);
            this.portButtonB.Name = "portButtonB";
            this.portButtonB.Size = new System.Drawing.Size(93, 23);
            this.portButtonB.TabIndex = 12;
            this.portButtonB.Text = "Connect";
            this.portButtonB.UseVisualStyleBackColor = true;
            this.portButtonB.Click += new System.EventHandler(this.connectButtonB_Click);
            // 
            // stopBoxB
            // 
            this.stopBoxB.FormattingEnabled = true;
            this.stopBoxB.Location = new System.Drawing.Point(65, 94);
            this.stopBoxB.Name = "stopBoxB";
            this.stopBoxB.Size = new System.Drawing.Size(121, 21);
            this.stopBoxB.Sorted = true;
            this.stopBoxB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stop Bit:";
            // 
            // parityBoxB
            // 
            this.parityBoxB.FormattingEnabled = true;
            this.parityBoxB.Location = new System.Drawing.Point(65, 67);
            this.parityBoxB.Name = "parityBoxB";
            this.parityBoxB.Size = new System.Drawing.Size(121, 21);
            this.parityBoxB.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Parity:";
            // 
            // recvTextB
            // 
            this.recvTextB.AutoSize = true;
            this.recvTextB.Location = new System.Drawing.Point(68, 152);
            this.recvTextB.Name = "recvTextB";
            this.recvTextB.Size = new System.Drawing.Size(0, 13);
            this.recvTextB.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Received:";
            // 
            // comBoxB
            // 
            this.comBoxB.FormattingEnabled = true;
            this.comBoxB.Location = new System.Drawing.Point(65, 13);
            this.comBoxB.Name = "comBoxB";
            this.comBoxB.Size = new System.Drawing.Size(121, 21);
            this.comBoxB.Sorted = true;
            this.comBoxB.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Com Port:";
            // 
            // baudBoxB
            // 
            this.baudBoxB.FormattingEnabled = true;
            this.baudBoxB.Location = new System.Drawing.Point(65, 40);
            this.baudBoxB.Name = "baudBoxB";
            this.baudBoxB.Size = new System.Drawing.Size(121, 21);
            this.baudBoxB.TabIndex = 4;
            // 
            // msgBoxB
            // 
            this.msgBoxB.Location = new System.Drawing.Point(65, 121);
            this.msgBoxB.Name = "msgBoxB";
            this.msgBoxB.Size = new System.Drawing.Size(187, 20);
            this.msgBoxB.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Baud Rate:";
            // 
            // sendButtonB
            // 
            this.sendButtonB.Location = new System.Drawing.Point(258, 118);
            this.sendButtonB.Name = "sendButtonB";
            this.sendButtonB.Size = new System.Drawing.Size(91, 23);
            this.sendButtonB.TabIndex = 2;
            this.sendButtonB.Text = "Send Message";
            this.sendButtonB.UseVisualStyleBackColor = true;
            this.sendButtonB.Click += new System.EventHandler(this.sendButtonB_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 373);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Name = "Form1";
            this.Text = "Com Port Communicator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox msgBoxA;
        private System.Windows.Forms.Button sendButtonA;
        private System.Windows.Forms.ComboBox baudBoxA;
        private System.Windows.Forms.ComboBox stopBoxA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityBoxA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recvTextA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.Button portButtonB;
        private System.Windows.Forms.ComboBox stopBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parityBoxB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label recvTextB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comBoxB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox baudBoxB;
        private System.Windows.Forms.TextBox msgBoxB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sendButtonB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button portButtonA;
    }
}


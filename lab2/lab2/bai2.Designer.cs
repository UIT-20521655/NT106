namespace Bai02_DocThongTinMotFileTXT
{
    partial class bai2
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
            groupBox1 = new GroupBox();
            btnExit = new Button();
            txtCharacter = new TextBox();
            label6 = new Label();
            txtWords = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtLine = new TextBox();
            txtUrl = new TextBox();
            label3 = new Label();
            txtSize = new TextBox();
            label2 = new Label();
            txtFilename = new TextBox();
            label1 = new Label();
            btnRead = new Button();
            txtHienthi = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(txtCharacter);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtWords);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLine);
            groupBox1.Controls.Add(txtUrl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSize);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFilename);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRead);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(414, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setting";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(306, 336);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCharacter
            // 
            txtCharacter.Location = new Point(125, 230);
            txtCharacter.Margin = new Padding(3, 4, 3, 4);
            txtCharacter.Name = "txtCharacter";
            txtCharacter.Size = new Size(279, 27);
            txtCharacter.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 230);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 11;
            label6.Text = "Character Count";
            // 
            // txtWords
            // 
            txtWords.Location = new Point(125, 195);
            txtWords.Margin = new Padding(3, 4, 3, 4);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(279, 27);
            txtWords.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 195);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Words Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 162);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 8;
            label4.Text = "Line Count";
            // 
            // txtLine
            // 
            txtLine.Location = new Point(125, 159);
            txtLine.Margin = new Padding(3, 4, 3, 4);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(279, 27);
            txtLine.TabIndex = 7;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(125, 124);
            txtUrl.Margin = new Padding(3, 4, 3, 4);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(279, 27);
            txtUrl.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 127);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "URL";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(125, 89);
            txtSize.Margin = new Padding(3, 4, 3, 4);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(279, 27);
            txtSize.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 92);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(125, 54);
            txtFilename.Margin = new Padding(3, 4, 3, 4);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(279, 27);
            txtFilename.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 57);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(6, 17);
            btnRead.Margin = new Padding(3, 4, 3, 4);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(398, 29);
            btnRead.TabIndex = 0;
            btnRead.Text = "READ FROM FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtHienthi
            // 
            txtHienthi.Location = new Point(432, 13);
            txtHienthi.Margin = new Padding(3, 4, 3, 4);
            txtHienthi.Name = "txtHienthi";
            txtHienthi.Size = new Size(463, 514);
            txtHienthi.TabIndex = 1;
            txtHienthi.Text = "";
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 540);
            Controls.Add(txtHienthi);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bai2";
            Text = "bai2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox txtHienthi;
    }
}


namespace lab1
{
    partial class Bai5
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
            Calc = new Button();
            del = new Button();
            label1 = new Label();
            label2 = new Label();
            A = new TextBox();
            B = new TextBox();
            label3 = new Label();
            check1 = new Label();
            check2 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            kq_s3 = new TextBox();
            kq_s2 = new TextBox();
            kq_s1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            kqB = new TextBox();
            kqA = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Calc
            // 
            Calc.BackColor = SystemColors.ActiveBorder;
            Calc.ForeColor = SystemColors.HotTrack;
            Calc.Location = new Point(37, 112);
            Calc.Name = "Calc";
            Calc.Size = new Size(271, 29);
            Calc.TabIndex = 0;
            Calc.Text = "Tính toán các giá trị";
            Calc.UseVisualStyleBackColor = false;
            Calc.Click += Calc_Click;
            // 
            // del
            // 
            del.BackColor = SystemColors.ButtonFace;
            del.ForeColor = Color.Red;
            del.Location = new Point(37, 157);
            del.Name = "del";
            del.Size = new Size(94, 29);
            del.TabIndex = 0;
            del.Text = "Xóa";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // A
            // 
            A.Location = new Point(99, 54);
            A.Name = "A";
            A.Size = new Size(125, 27);
            A.TabIndex = 2;
            A.TextChanged += A_TextChanged;
            // 
            // B
            // 
            B.Location = new Point(447, 54);
            B.Name = "B";
            B.Size = new Size(125, 27);
            B.TabIndex = 2;
            B.TextChanged += B_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 1;
            label3.Text = "Tính toán với hai số nguyên A và B";
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.Location = new Point(94, 89);
            check1.Name = "check1";
            check1.Size = new Size(0, 20);
            check1.TabIndex = 4;
            // 
            // check2
            // 
            check2.AutoSize = true;
            check2.Location = new Point(442, 89);
            check2.Name = "check2";
            check2.Size = new Size(0, 20);
            check2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(kq_s3);
            groupBox1.Controls.Add(kq_s2);
            groupBox1.Controls.Add(kq_s1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(kqB);
            groupBox1.Controls.Add(kqA);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(37, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 190);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "KẾT QUẢ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(334, 40);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(86, 40);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 4;
            // 
            // kq_s3
            // 
            kq_s3.ForeColor = Color.Blue;
            kq_s3.Location = new Point(359, 143);
            kq_s3.Name = "kq_s3";
            kq_s3.Size = new Size(125, 27);
            kq_s3.TabIndex = 3;
            // 
            // kq_s2
            // 
            kq_s2.ForeColor = Color.Blue;
            kq_s2.Location = new Point(359, 110);
            kq_s2.Name = "kq_s2";
            kq_s2.Size = new Size(125, 27);
            kq_s2.TabIndex = 3;
            // 
            // kq_s1
            // 
            kq_s1.ForeColor = Color.Blue;
            kq_s1.Location = new Point(359, 72);
            kq_s1.Name = "kq_s1";
            kq_s1.Size = new Size(125, 27);
            kq_s1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(92, 146);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(93, 113);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(92, 75);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 2;
            // 
            // kqB
            // 
            kqB.ForeColor = Color.Blue;
            kqB.Location = new Point(359, 37);
            kqB.Name = "kqB";
            kqB.Size = new Size(125, 27);
            kqB.TabIndex = 1;
            kqB.TextChanged += textBox2_TextChanged;
            // 
            // kqA
            // 
            kqA.ForeColor = Color.Blue;
            kqA.Location = new Point(105, 37);
            kqA.Name = "kqA";
            kqA.Size = new Size(125, 27);
            kqA.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(291, 40);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 0;
            label8.Text = "B! = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(42, 146);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 0;
            label7.Text = "S3 = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(42, 113);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 0;
            label6.Text = "S2 = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(42, 75);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 0;
            label5.Text = "S1 = ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(42, 40);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 0;
            label4.Text = "A! = ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(214, 157);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 428);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(check2);
            Controls.Add(check1);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(del);
            Controls.Add(Calc);
            Name = "Bai5";
            Text = "Bai5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calc;
        private Button del;
        private Label label1;
        private Label label2;
        private TextBox A;
        private TextBox B;
        private Label label3;
        private Label check1;
        private Label check2;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox kqB;
        private TextBox kqA;
        private TextBox kq_s3;
        private TextBox kq_s2;
        private TextBox kq_s1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label12;
        private Button button1;
    }
}
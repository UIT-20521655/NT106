namespace lab1
{
    partial class Bai2
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
            st1 = new Label();
            st2 = new Label();
            st3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            tx_st1 = new TextBox();
            tx_st2 = new TextBox();
            tx_st3 = new TextBox();
            big = new TextBox();
            small = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // st1
            // 
            st1.AutoSize = true;
            st1.Location = new Point(12, 70);
            st1.Name = "st1";
            st1.Size = new Size(85, 20);
            st1.TabIndex = 0;
            st1.Text = "Số thứ nhất";
            // 
            // st2
            // 
            st2.AutoSize = true;
            st2.Location = new Point(258, 70);
            st2.Name = "st2";
            st2.Size = new Size(76, 20);
            st2.TabIndex = 0;
            st2.Text = "Số thứ hai";
            // 
            // st3
            // 
            st3.AutoSize = true;
            st3.Location = new Point(496, 70);
            st3.Name = "st3";
            st3.Size = new Size(73, 20);
            st3.TabIndex = 0;
            st3.Text = "Số thứ ba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 189);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 244);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 0;
            label5.Text = "Số nhỏ nhất";
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(361, 213);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tx_st1
            // 
            tx_st1.Location = new Point(94, 67);
            tx_st1.Name = "tx_st1";
            tx_st1.Size = new Size(125, 27);
            tx_st1.TabIndex = 2;
            tx_st1.TextChanged += tx_st1_TextChanged;
            tx_st1.KeyPress += tx_st1_KeyPress;
            // 
            // tx_st2
            // 
            tx_st2.Location = new Point(330, 67);
            tx_st2.Name = "tx_st2";
            tx_st2.Size = new Size(125, 27);
            tx_st2.TabIndex = 2;
            tx_st2.TextChanged += tx_st2_TextChanged;
            tx_st2.KeyPress += tx_st2_KeyPress;
            // 
            // tx_st3
            // 
            tx_st3.Location = new Point(566, 67);
            tx_st3.Name = "tx_st3";
            tx_st3.Size = new Size(125, 27);
            tx_st3.TabIndex = 2;
            tx_st3.TextChanged += tx_st3_TextChanged;
            tx_st3.KeyPress += tx_st3_KeyPress;
            // 
            // big
            // 
            big.BackColor = SystemColors.InactiveCaption;
            big.ForeColor = Color.FromArgb(0, 0, 192);
            big.Location = new Point(175, 186);
            big.Name = "big";
            big.Size = new Size(125, 27);
            big.TabIndex = 2;
            big.TextChanged += big_TextChanged;
            // 
            // small
            // 
            small.BackColor = SystemColors.InactiveCaption;
            small.ForeColor = SystemColors.HotTrack;
            small.Location = new Point(175, 241);
            small.Name = "small";
            small.Size = new Size(125, 27);
            small.TabIndex = 2;
            small.TextChanged += small_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 0;
            label1.Text = "Số lớn nhất, nhỏ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 97);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 97);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(566, 97);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 3;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(175, 130);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "So sánh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(528, 213);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 294);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(small);
            Controls.Add(big);
            Controls.Add(tx_st3);
            Controls.Add(tx_st2);
            Controls.Add(tx_st1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(st3);
            Controls.Add(st2);
            Controls.Add(label1);
            Controls.Add(st1);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label st1;
        private Label st2;
        private Label st3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox tx_st1;
        private TextBox tx_st2;
        private TextBox tx_st3;
        private TextBox big;
        private TextBox small;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Button button1;
        private Button button3;
    }
}
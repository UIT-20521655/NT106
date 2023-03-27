namespace lab1
{
    partial class Bai1
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
            ST1 = new TextBox();
            tx_st1 = new Label();
            tx_st2 = new Label();
            ST2 = new TextBox();
            bt_Sum = new Button();
            Ketqua = new TextBox();
            Kq = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ST1
            // 
            ST1.Location = new Point(158, 74);
            ST1.Name = "ST1";
            ST1.Size = new Size(125, 27);
            ST1.TabIndex = 0;
            ST1.TextChanged += textBox1_TextChanged;
            // 
            // tx_st1
            // 
            tx_st1.AutoSize = true;
            tx_st1.Location = new Point(58, 77);
            tx_st1.Name = "tx_st1";
            tx_st1.Size = new Size(94, 20);
            tx_st1.TabIndex = 1;
            tx_st1.Text = "Số Thứ Nhất:";
            tx_st1.Click += label1_Click;
            // 
            // tx_st2
            // 
            tx_st2.AutoSize = true;
            tx_st2.Location = new Point(58, 151);
            tx_st2.Name = "tx_st2";
            tx_st2.Size = new Size(85, 20);
            tx_st2.TabIndex = 1;
            tx_st2.Text = "Số Thứ Hai:";
            tx_st2.Click += label1_Click;
            // 
            // ST2
            // 
            ST2.Location = new Point(158, 148);
            ST2.Name = "ST2";
            ST2.Size = new Size(125, 27);
            ST2.TabIndex = 0;
            ST2.TextChanged += ST2_TextChanged;
            // 
            // bt_Sum
            // 
            bt_Sum.BackColor = SystemColors.GradientActiveCaption;
            bt_Sum.ForeColor = Color.Navy;
            bt_Sum.Location = new Point(312, 146);
            bt_Sum.Name = "bt_Sum";
            bt_Sum.Size = new Size(94, 29);
            bt_Sum.TabIndex = 2;
            bt_Sum.Text = "Cộng";
            bt_Sum.UseVisualStyleBackColor = false;
            bt_Sum.Click += bt_Sum_Click;
            // 
            // Ketqua
            // 
            Ketqua.BackColor = SystemColors.InactiveCaption;
            Ketqua.ForeColor = SystemColors.HotTrack;
            Ketqua.Location = new Point(383, 74);
            Ketqua.Name = "Ketqua";
            Ketqua.Size = new Size(125, 27);
            Ketqua.TabIndex = 0;
            // 
            // Kq
            // 
            Kq.AutoSize = true;
            Kq.ForeColor = Color.Red;
            Kq.Location = new Point(312, 77);
            Kq.Name = "Kq";
            Kq.Size = new Size(65, 20);
            Kq.TabIndex = 1;
            Kq.Text = "Kết Quả:";
            Kq.Click += label1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 35);
            label1.TabIndex = 3;
            label1.Text = "Tính tổng 2 số nguyên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 104);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 178);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(414, 147);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(414, 201);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 241);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_Sum);
            Controls.Add(Kq);
            Controls.Add(tx_st2);
            Controls.Add(tx_st1);
            Controls.Add(Ketqua);
            Controls.Add(ST2);
            Controls.Add(ST1);
            MaximizeBox = false;
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ST1;
        private Label tx_st1;
        private Label tx_st2;
        private TextBox ST2;
        private Button bt_Sum;
        private TextBox Ketqua;
        private Label Kq;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
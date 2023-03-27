namespace lab1
{
    partial class Bai3
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
            nhapso = new TextBox();
            kq = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // nhapso
            // 
            nhapso.Location = new Point(308, 51);
            nhapso.Name = "nhapso";
            nhapso.Size = new Size(125, 27);
            nhapso.TabIndex = 0;
            nhapso.TextChanged += nhapso_TextChanged;
            // 
            // kq
            // 
            kq.BackColor = SystemColors.InactiveCaption;
            kq.ForeColor = SystemColors.HotTrack;
            kq.Location = new Point(308, 115);
            kq.Name = "kq";
            kq.Size = new Size(125, 27);
            kq.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 1;
            label1.Text = "Đọc số ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 54);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Kết quả";
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(56, 170);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(191, 170);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Green;
            button3.Location = new Point(323, 170);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 226);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kq);
            Controls.Add(nhapso);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nhapso;
        private TextBox kq;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
namespace lab1
{
    partial class Bai4
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            loaitien = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            Sotien = new TextBox();
            vnd = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label10 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // loaitien
            // 
            loaitien.FormattingEnabled = true;
            loaitien.Items.AddRange(new object[] { "USD", "EUR", "GBP", "SGD", "JPY" });
            loaitien.Location = new Point(260, 45);
            loaitien.Name = "loaitien";
            loaitien.Size = new Size(58, 28);
            loaitien.TabIndex = 2;
            loaitien.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 90);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 4;
            label1.Text = "Nhập số tiền cần đổi     :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 4;
            label2.Text = "Chuyển đổi tiền tệ sang VND";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(14, 53);
            label4.Name = "label4";
            label4.Size = new Size(240, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn đơn vị tiền tệ cần đổi              :";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(14, 128);
            button1.Name = "button1";
            button1.Size = new Size(306, 29);
            button1.TabIndex = 5;
            button1.Text = "Chuyển Đổi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 179);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 4;
            label3.Text = "Số tiền đã đổi                 :";
            // 
            // Sotien
            // 
            Sotien.Location = new Point(193, 83);
            Sotien.Name = "Sotien";
            Sotien.Size = new Size(125, 27);
            Sotien.TabIndex = 6;
            Sotien.TextChanged += Sotien_TextChanged;
            // 
            // vnd
            // 
            vnd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            vnd.Location = new Point(193, 172);
            vnd.Name = "vnd";
            vnd.Size = new Size(125, 27);
            vnd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(328, 175);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "(VND)";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(193, 222);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(328, 86);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(271, 222);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(14, 222);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 4;
            label6.Text = "Tỉ giá quy đổi                   :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(328, 222);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 11;
            label10.Text = "(VND)";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(328, 9);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 252);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(vnd);
            Controls.Add(Sotien);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loaitien);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox loaitien;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox Sotien;
        private TextBox vnd;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label10;
        private Button button2;
    }
}
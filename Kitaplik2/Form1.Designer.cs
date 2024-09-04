namespace Kitaplik2
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(303, 31);
            label1.TabIndex = 2;
            label1.Text = "Admin Paneline Hoşgeldiniz";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 682);
            panel2.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.AliceBlue;
            button8.Location = new Point(0, 571);
            button8.Name = "button8";
            button8.Size = new Size(199, 74);
            button8.TabIndex = 1;
            button8.Text = "Sil";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.AliceBlue;
            button7.Location = new Point(0, 491);
            button7.Name = "button7";
            button7.Size = new Size(199, 74);
            button7.TabIndex = 1;
            button7.Text = "Güncelle";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.AliceBlue;
            button6.Location = new Point(1, 411);
            button6.Name = "button6";
            button6.Size = new Size(199, 74);
            button6.TabIndex = 1;
            button6.Text = "Ekle";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Location = new Point(1, 331);
            button5.Name = "button5";
            button5.Size = new Size(199, 74);
            button5.TabIndex = 1;
            button5.Text = "Kitaplar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.AliceBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 240);
            button4.Name = "button4";
            button4.Size = new Size(199, 74);
            button4.TabIndex = 0;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1, 160);
            button3.Name = "button3";
            button3.Size = new Size(199, 74);
            button3.TabIndex = 0;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 80);
            button2.Name = "button2";
            button2.Size = new Size(199, 74);
            button2.TabIndex = 0;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(199, 74);
            button1.TabIndex = 0;
            button1.Text = "Kullanıcılar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 682);
            Controls.Add(panel1);
            Controls.Add(panel2);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}
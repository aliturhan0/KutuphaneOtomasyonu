namespace Kitaplik2
{
    partial class KullanıcıGüncelle
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            radioButton2 = new RadioButton();
            label2 = new Label();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(48, 316);
            button1.Name = "button1";
            button1.Size = new Size(354, 59);
            button1.TabIndex = 19;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(168, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(234, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(168, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 18;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(166, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(48, 266);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 7;
            label2.Text = "Şifre :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(252, 73);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(48, 221);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 8;
            label6.Text = "Kullanıcı Adı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(48, 182);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 9;
            label8.Text = "Telefon :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(48, 73);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 10;
            label3.Text = "Cinsiyet :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 6;
            label1.Text = "Ad Soyad :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 630);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(48, 148);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 21;
            label5.Text = "T.C. :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(48, 114);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 22;
            label4.Text = "Mail : ";
            // 
            // KullanıcıGüncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1211, 706);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "KullanıcıGüncelle";
            Text = "KullanıcıGüncelle";
            Load += KullanıcıGüncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private Label label2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
    }
}
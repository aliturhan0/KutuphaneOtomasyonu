
namespace Kitaplik2
{
    partial class GirişEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişEkranı));
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(79, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Girişi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 30);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 30);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(6, 151);
            button2.Name = "button2";
            button2.Size = new Size(276, 29);
            button2.TabIndex = 7;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(9, 111);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre : ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(9, 72);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(419, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 197);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admin Girişi";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 67);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 30);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 30);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(6, 151);
            button1.Name = "button1";
            button1.Size = new Size(285, 29);
            button1.TabIndex = 7;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(8, 111);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Şifre : ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(8, 72);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı Adı : ";
            label3.Click += label3_Click;
            // 
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(818, 521);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GirişEkranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomason Sistemine Hoşgeldiniz";
            Load += GirişEkranı_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
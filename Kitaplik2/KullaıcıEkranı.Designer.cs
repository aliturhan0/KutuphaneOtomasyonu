namespace Kitaplik2
{
    partial class KullaıcıEkranı
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
            button6 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button1.Location = new Point(0, 67);
            button1.Name = "button1";
            button1.Size = new Size(180, 195);
            button1.TabIndex = 0;
            button1.Text = "Kitap Ödünç Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button6.Location = new Point(0, 323);
            button6.Name = "button6";
            button6.Size = new Size(180, 195);
            button6.TabIndex = 2;
            button6.Text = "Kitap Bırak";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 723);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(180, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 66);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 17);
            label1.Name = "label1";
            label1.Size = new Size(322, 31);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Paneline Hoşgeldiniz";
            // 
            // KullaıcıEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1202, 723);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "KullaıcıEkranı";
            Text = "Kullanıcı Paneli";
            Load += KullanıcıGiriş_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    
        private Button button6;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
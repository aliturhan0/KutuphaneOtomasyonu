﻿namespace Kitaplik2
{
    partial class KitapBirak1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1099, 644);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button1.Location = new Point(21, 23);
            button1.Name = "button1";
            button1.Size = new Size(100, 644);
            button1.TabIndex = 1;
            button1.Text = "Kitap Bırak";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KitapBirak1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1297, 688);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "KitapBirak1";
            Text = "KitapListe";
            Load += KitapListe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
    }
}
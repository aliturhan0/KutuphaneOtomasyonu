using Kitaplik.Entities;
using Kitaplik2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kitaplik2
{
    public partial class KitapEkle : Form
    {
        AppDbContext _context = new AppDbContext();
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book kitap = new Book();
            kitap.Name = textBox1.Text;
            kitap.ISBN = textBox3.Text;
            kitap.Author = textBox4.Text;
            kitap.Category = textBox5.Text;
            kitap.SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);
            kitap.Status = "DefaultStatus";

            _context.Books.Add(kitap);
            _context.SaveChanges();

            var KitapListe = _context.Books.ToList();
            dataGridView1.DataSource = KitapListe.ToList();
        }
    }
}

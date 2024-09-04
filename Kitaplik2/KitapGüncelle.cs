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

namespace Kitaplik2
{
    public partial class KitapGüncelle : Form
    {

        AppDbContext _context = new AppDbContext();
        public KitapGüncelle()
        {
            InitializeComponent();
        }

        private void KitapGüncelle_Load(object sender, EventArgs e)
        {
            var book = _context.Books.ToList();
            dataGridView1.DataSource = book.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKitap = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenenKitap = _context.Books.Where(x => x.BookID == secilenKitap).FirstOrDefault();
            guncellenenKitap.Name = textBox1.Text;
            guncellenenKitap.ISBN = textBox3.Text;
            guncellenenKitap.Author = textBox4.Text;
            guncellenenKitap.Category = textBox5.Text;
            guncellenenKitap.SayfaSayisi =Convert.ToInt32 (numericUpDown1.Value);
            _context.SaveChanges();

            var book = _context.Books.ToList();
            dataGridView1.DataSource = book.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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

namespace Kitaplik2
{
    public partial class KitapSil : Form
    {
        AppDbContext _context = new AppDbContext();
        public KitapSil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            var book = _context.Books.ToList();
            dataGridView1.DataSource = book;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKitap = _context.Books.Where(x=>x.BookID == secilenID).FirstOrDefault();
            _context.Books.Remove(silinenKitap);
            _context.SaveChanges();

            var book = _context.Books.ToList();
            dataGridView1.DataSource = book;
        }
    }
}

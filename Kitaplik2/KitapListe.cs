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
    public partial class KitapListe : Form
    {
        AppDbContext _context = new AppDbContext();
        public KitapListe()
        {

            InitializeComponent();
        }

        private void KitapListe_Load(object sender, EventArgs e)
        {
            var books = _context.Books.ToList();
            dataGridView1.DataSource = books;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

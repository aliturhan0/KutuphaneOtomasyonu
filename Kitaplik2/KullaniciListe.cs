using Kitaplik2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik2
{
    public partial class KullaniciListe : Form
    {
        AppDbContext _context = new AppDbContext();
        public KullaniciListe()
        {
            InitializeComponent();
            _context = new AppDbContext();
            
        }
        private void KullaniciListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            var Users =_context.Users.ToList();
            dataGridView1.DataSource = Users;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

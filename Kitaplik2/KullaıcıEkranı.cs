using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Kitaplik.Entities;
using Kitaplik2.DAL;  
using Kitaplik2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Kitaplik2
{
    public partial class KullaıcıEkranı : Form
    {
        private int _currentUserId;
        private AppDbContext _context;

        public KullaıcıEkranı()
        {

            InitializeComponent();
            _context = new AppDbContext();
        }
        public void SetCurrentUserId(int userId)
        {
            _currentUserId = userId;
        }
        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {
 

        }



        private void button1_Click(object sender, EventArgs e)
        {

              KitapAl kitapAl = new KitapAl(_currentUserId);
              kitapAl.MdiParent = this;
              kitapAl.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KitapBirak1 KitapListe = new KitapBirak1(_currentUserId);
            KitapListe.MdiParent = this;
            KitapListe.Show();
        }
    }
}

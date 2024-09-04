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
    public partial class Form1 : Form
    {
        AppDbContext _context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible == false)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }

            KullaniciListe kullaniciListe = new KullaniciListe();
            kullaniciListe.MdiParent = this;
            kullaniciListe.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullaniciekle = new KullanıcıEkle();
            kullaniciekle.MdiParent = this;
            kullaniciekle.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullanıcıSil = new KullanıcıSil();
            kullanıcıSil.MdiParent = this;
            kullanıcıSil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıGüncelle kullanıcıGüncelle = new KullanıcıGüncelle();
            kullanıcıGüncelle.MdiParent = this;
            kullanıcıGüncelle.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button6.Visible == false)
            {
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
            }
            else
            {
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            KitapListe kitapListe = new KitapListe();
            kitapListe.MdiParent = this;
            kitapListe.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KitapEkle kitap = new KitapEkle();
            kitap.MdiParent = this;
            kitap.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KitapSil kitapSil = new KitapSil();
            kitapSil.MdiParent = this;
            kitapSil.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KitapGüncelle kitapGüncelle = new KitapGüncelle();
            kitapGüncelle.MdiParent = this;
            kitapGüncelle.Show();
        }
    }
}

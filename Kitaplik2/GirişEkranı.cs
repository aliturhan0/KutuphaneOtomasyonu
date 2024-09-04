using Kitaplik.Entities;
using Kitaplik2.DAL;
using Kitaplik2.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class GirişEkranı : Form
    {


        
        AppDbContext _context = new AppDbContext();
        private int _currentUserId;
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı, şifre;
            kullanıcıAdı = textBox4.Text;
            şifre = textBox3.Text;
            if (kullanıcıAdı == "admin" && şifre == "123")
            {
                MessageBox.Show("Giriş Yapıldı");
                Form form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private AppDbContext Get_context()
        {
            return _context;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = textBox1.Text;
            string şifre = textBox2.Text;
           
            if (string.IsNullOrEmpty(kullanıcıAdı) || string.IsNullOrEmpty(şifre))
            {
                
                MessageBox.Show("Kullanıcı adı ve şifre girilmelidir.");
                return;
            }

           
            var user = _context.Users.FirstOrDefault(u => u.KullaniciAdi == kullanıcıAdı && u.Sifre == şifre);


            if (user != null)
            {
                _currentUserId = user.ID;
                MessageBox.Show("Giriş Yapıldı");
               
                KullaıcıEkranı kullanıcıGiriş = new KullaıcıEkranı();
                kullanıcıGiriş.SetCurrentUserId(_currentUserId);
                kullanıcıGiriş.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            User user = new User();

            

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

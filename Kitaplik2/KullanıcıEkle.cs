using Kitaplik2.DAL;
using Kitaplik2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik2
{
    public partial class KullanıcıEkle : Form
    {
        AppDbContext _context = new AppDbContext();
        public KullanıcıEkle()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            User users = new User();

            users.KullaniciAdi = textBox6.Text;
            users.Name = textBox1.Text;
            users.Telefon = textBox5.Text;
            users.TC= textBox4.Text;
            users.Mail = textBox3.Text;
            users.Sifre =textBox2.Text;
            if (radioButton1.Checked== true)
            {
                users.Cinsiyet = "Kadın";
            }
            else if (radioButton2.Checked==true)
            {
                users.Cinsiyet = "Erkek";
            }
            _context.Users.Add(users);
            _context.SaveChanges(); 
            Listele();

        }
        public void Listele()
        {
            var users = _context.Users
    .AsNoTracking() 
    .Select(user => new
    {
        ID = user.ID,
        KullaniciAdi = user.KullaniciAdi,
        Name = user.Name,
        Telefon = user.Telefon,
        TC = user.TC,
        Mail = user.Mail,
        Cinsiyet = user.Cinsiyet,
        Sifre = user.Sifre
    })
    .ToList();

            dataGridView1.DataSource = users;
        }
        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

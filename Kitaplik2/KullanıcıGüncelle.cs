using Kitaplik2.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik2
{
    public partial class KullanıcıGüncelle : Form
    {
        AppDbContext _context = new AppDbContext();

        public KullanıcıGüncelle()
        {
            InitializeComponent();
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


        private void KullanıcıGüncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;

            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("E"))
                radioButton2.Checked = true;
            else radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir kullanıcı seçmelisiniz.");
                return;
            }

            int secilenID;
            if (!int.TryParse(dataGridView1.CurrentRow.Cells[0].Value?.ToString(), out secilenID))
            {
                MessageBox.Show("Geçersiz kullanıcı ID'si.");
                return;
            }

            var kullanici = _context.Users.FirstOrDefault(x => x.ID == secilenID);

            if (kullanici == null)
            {
                MessageBox.Show("Seçilen kullanıcı bulunamadı.");
                return;
            }
            kullanici.KullaniciAdi = textBox6.Text;
            kullanici.Sifre = textBox2.Text;
            kullanici.Mail = textBox3.Text;
            kullanici.Name = textBox1.Text;
            kullanici.TC = textBox4.Text;
            kullanici.Telefon = textBox5.Text;
            kullanici.Cinsiyet = radioButton1.Checked ? "E" : "K";

            _context.Users.Update(kullanici);
            _context.SaveChanges();

            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}

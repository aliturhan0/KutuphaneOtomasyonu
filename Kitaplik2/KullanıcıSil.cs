using Kitaplik2.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Kitaplik2
{
    public partial class KullanıcıSil : Form
    {
        AppDbContext _context = new AppDbContext();

        public KullanıcıSil()
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

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kullanıcı seçmelisiniz.");
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

            var loans = _context.Loans.Where(l => l.UserID == secilenID).ToList();
            if (loans.Any())
            {
                _context.Loans.RemoveRange(loans);
            }

            _context.Users.Remove(kullanici);
            _context.SaveChanges();

            MessageBox.Show("Kullanıcı ve ona bağlı ödünç kayıtları silindi.");
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

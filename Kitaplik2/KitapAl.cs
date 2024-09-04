using Kitaplik2.DAL;
using Kitaplik2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Kitaplik2
{
    public partial class KitapAl : Form
    {
        private int _currentUserId;
        private AppDbContext _context;

        public KitapAl(int currentUserId)
        {
            InitializeComponent();
            _currentUserId = currentUserId;
            _context = new AppDbContext(); 
        }

        private void LoadBooks()
        {
            var books = _context.Books.ToList();
            dataGridView1.DataSource = books;
        }

        private void KitapAl_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen ödünç almak istediğiniz kitabı seçin.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
           
            int secilenKitap;
            if (!int.TryParse(selectedRow.Cells[0].Value.ToString(), out secilenKitap))
            {
                MessageBox.Show("Geçerli bir kitap ID'si bulunamadı.");
                return;
            }

            var user = _context.Users.FirstOrDefault(u => u.ID == _currentUserId);
            if (user == null)
            {
                MessageBox.Show("Geçerli bir kullanıcı bulunamadı.");
                return;
            }

            var loan = new Loan
            {
                BookId = secilenKitap,
                UserID = _currentUserId,
                LoanDate = DateTime.Now,
                ReturnDate= DateTime.Now
            };

            var book = _context.Books.Find(secilenKitap);
            if (book == null)
            {
                MessageBox.Show("Seçilen kitap bulunamadı.");
                return;
            }

            book.Status = "Ödünç Alındı";
            _context.Books.Update(book);

            _context.Loans.Add(loan);

            try
            {
                _context.SaveChanges();
                MessageBox.Show("Kitap başarıyla ödünç alındı.");
                LoadBooks();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

using Kitaplik2.DAL;
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

namespace Kitaplik2
{
    public partial class KitapBirak1 : Form
    {
        private int _currentUserId;
        AppDbContext _context = new AppDbContext();
        public KitapBirak1(int currentUserId)
        {
            InitializeComponent();
            _currentUserId = currentUserId;
        }

        public void KitapListele()
        {
            var loans = _context.Loans
            .AsNoTracking()
            .Where(loan => loan.UserID == _currentUserId)
            .Select(loan => new
            {
                ID = loan.ID,
                BookId = loan.BookId,
                UserID = loan.UserID,
                LoanDate = loan.LoanDate,
                ReurnDate = loan.ReturnDate
        })
            .ToList();
            _context.SaveChanges();

            dataGridView1.DataSource = loans;
        }

        private void KitapListe_Load(object sender, EventArgs e)
        {
            KitapListele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenLoan = _context.Loans.Where(x => x.ID == secilenID).FirstOrDefault();

            if (silinenLoan != null)
            {
                var book = _context.Books.Where(x => x.BookID == silinenLoan.BookId).FirstOrDefault();
                if (book != null)
                {
                    book.Status = "Mevcut";  
                    _context.Books.Update(book);
                }

                _context.Loans.Remove(silinenLoan);
                _context.SaveChanges();

                var loans = _context.Loans.ToList();
                dataGridView1.DataSource = loans;

                MessageBox.Show("Kitap başarıyla geri alındı.");
            }
            else
            {
                MessageBox.Show("Seçilen kayıt bulunamadı.");
            }

        }
    }
    
}

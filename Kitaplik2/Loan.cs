using Kitaplik.Entities;

namespace Kitaplik2.Entities
{
    public class Loan
    {
        public int ID { get; set; }
        public int BookId { get; set; }
        public int? UserID { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable, yani opsiyonel
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
       
    }
}


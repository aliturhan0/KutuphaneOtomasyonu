using Kitaplik.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik2.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }  
        public string? Telefon { get; set; }
        public string? TC { get; set; }
        public string? Sifre { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Mail{ get; set; }
        public string? Cinsiyet { get; set; }
        public Book? Book { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }


    }
}

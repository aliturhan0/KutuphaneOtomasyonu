using Kitaplik2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public string? Name { get; set; }
        public string? ISBN { get; set; }
        public string? Category { get; set; }
        public string? Author { get; set; }
        public int SayfaSayisi{ get; set; }

        public IEnumerable<User> Users { get; set; }
        public string? Status { get; set; } = "DefaultStatus";
    }
}

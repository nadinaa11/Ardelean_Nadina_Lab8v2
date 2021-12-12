using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardelean_Nadina_Lab8v2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}

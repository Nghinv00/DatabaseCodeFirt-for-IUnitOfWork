using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauLe.Model.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public Nullable<int> Ord { get; set; }
        public string Lang { get; set; }
        public string NameEn { get; set; }
    }
}

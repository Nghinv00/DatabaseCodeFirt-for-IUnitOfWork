using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HauLe.WebApi.Models
{
    public class BrandViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public int ? Ord { get; set; }
        public string Lang { get; set; }
        public string NameEn { get; set; }
    }
}
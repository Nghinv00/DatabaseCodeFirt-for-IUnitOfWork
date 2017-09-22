//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HauLe.Model.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Level { get; set; }
        public Nullable<short> Priority { get; set; }
        public Nullable<short> Index { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<int> Ord { get; set; }
        public string Lang { get; set; }
        public string Image2 { get; set; }
        public string NameEn { get; set; }
        public string ContentEn { get; set; }
        public string TitleEn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}

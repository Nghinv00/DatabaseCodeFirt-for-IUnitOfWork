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
    
    public partial class tbCUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCUSTOMER()
        {
            this.tbBill_customers = new HashSet<tbBill_customers>();
        }
    
        public int iusid { get; set; }
        public string vusername { get; set; }
        public string vpassword { get; set; }
        public string vcusname { get; set; }
        public string dbirthday { get; set; }
        public string vprovince { get; set; }
        public string vaddress { get; set; }
        public string vphone { get; set; }
        public string vmobile { get; set; }
        public string vemail { get; set; }
        public Nullable<System.DateTime> dcreatedate { get; set; }
        public Nullable<short> istatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBill_customers> tbBill_customers { get; set; }
    }
}

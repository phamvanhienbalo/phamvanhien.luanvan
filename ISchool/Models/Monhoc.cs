//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISchool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monhoc()
        {
            this.Chuyennganh_Monhoc = new HashSet<Chuyennganh_Monhoc>();
        }
    
        public int MAMH { get; set; }
        public string TENMH { get; set; }
        public string MOTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuyennganh_Monhoc> Chuyennganh_Monhoc { get; set; }
    }
}
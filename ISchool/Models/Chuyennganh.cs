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
    
    public partial class Chuyennganh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chuyennganh()
        {
            this.Chuyennganh_Monhoc = new HashSet<Chuyennganh_Monhoc>();
            this.Giangviens = new HashSet<Giangvien>();
            this.Sinhviens = new HashSet<Sinhvien>();
        }
    
        public int MACN { get; set; }
        public string TENCN { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> MAKHOA { get; set; }
    
        public virtual Khoa Khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuyennganh_Monhoc> Chuyennganh_Monhoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giangvien> Giangviens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}

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
    
    public partial class Donvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donvi()
        {
            this.Giangviens = new HashSet<Giangvien>();
        }
    
        public int MADV { get; set; }
        public string TENDV { get; set; }
        public string MOTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giangvien> Giangviens { get; set; }
    }
}

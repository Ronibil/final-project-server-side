//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSuperStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSuperStudent()
        {
            this.tblClass = new HashSet<tblClass>();
        }
    
        public string StudentId { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string DepartmentName { get; set; }
        public string StudyYear { get; set; }
        public Nullable<int> NumOfRanks { get; set; }
        public Nullable<short> RankAverage { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> CumulativeRank { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClass> tblClass { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}

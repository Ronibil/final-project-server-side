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
    
    public partial class tblRequestToJoinSuperStudent
    {
        public int RequsetNum { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string DepartmentName { get; set; }
        public string StudyYear { get; set; }
        public string ImagePath { get; set; }
    
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblRequestToJoin tblRequestToJoin { get; set; }
    }
}

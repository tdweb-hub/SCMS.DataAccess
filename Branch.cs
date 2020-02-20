//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCMS.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branch
    {
        public System.Guid Guid { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int SchoolId { get; set; }
        public Nullable<int> BranchLocation { get; set; }
        public Nullable<int> BranchAddress { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Remark { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Location Location { get; set; }
        public virtual School School { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

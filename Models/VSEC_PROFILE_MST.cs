//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIAwithAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VSEC_PROFILE_MST
    {
        public VSEC_PROFILE_MST()
        {
            this.VSEC_LOGIN_MST = new HashSet<VSEC_LOGIN_MST>();
        }
    
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public int PwdExpDays { get; set; }
        public int PwdRetryCount { get; set; }
        public int PwdGracePeriod { get; set; }
        public Nullable<int> NoofSessions { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
    
        public virtual ICollection<VSEC_LOGIN_MST> VSEC_LOGIN_MST { get; set; }
    }
}

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
    
    public partial class M_DelayedChrg_MST
    {
        public int ChargesID { get; set; }
        public string ChargeType { get; set; }
        public string TerminalCode { get; set; }
        public string Module { get; set; }
        public Nullable<int> FormType { get; set; }
        public Nullable<decimal> DaysFrom { get; set; }
        public Nullable<decimal> DaysTo { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Per { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> PrevSlabAmt { get; set; }
        public Nullable<decimal> MinCap { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
    }
}

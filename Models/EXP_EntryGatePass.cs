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
    
    public partial class EXP_EntryGatePass
    {
        public decimal EntryGatePassId { get; set; }
        public string EntryGatePassNo { get; set; }
        public Nullable<System.DateTime> EntryGatePassDate { get; set; }
        public Nullable<decimal> CourierCoId { get; set; }
        public string FlightNo { get; set; }
        public Nullable<System.DateTime> FlightDate { get; set; }
        public Nullable<int> NoofBags { get; set; }
        public Nullable<int> NoofShps { get; set; }
        public Nullable<int> NoofPkgs { get; set; }
        public Nullable<decimal> EntryWeight { get; set; }
        public Nullable<int> CSB3 { get; set; }
        public Nullable<int> CSB4 { get; set; }
        public string EntryPersonStaff { get; set; }
        public string VehicleNo { get; set; }
        public string RTOGatePassNo { get; set; }
        public Nullable<System.DateTime> RTOGatePassDate { get; set; }
        public string RTOReason { get; set; }
        public string RTORemarks { get; set; }
        public Nullable<int> TimeOfDeparture { get; set; }
        public string TerminalCode { get; set; }
        public string FinYear { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
        public Nullable<int> VersionNo { get; set; }
    }
}

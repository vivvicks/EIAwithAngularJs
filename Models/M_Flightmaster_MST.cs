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
    
    public partial class M_Flightmaster_MST
    {
        public string FlightNumber { get; set; }
        public string MigratedFlightNumber { get; set; }
        public string AirlineCode { get; set; }
        public string AirportofDeparture { get; set; }
        public string AirportofDestination { get; set; }
        public Nullable<int> ETD { get; set; }
        public Nullable<int> ETA { get; set; }
        public string FlightType { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
    }
}

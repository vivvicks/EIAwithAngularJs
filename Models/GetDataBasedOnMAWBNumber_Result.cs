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
    
    public partial class GetDataBasedOnMAWBNumber_Result
    {
        public Nullable<int> ActualNoofPackages { get; set; }
        public Nullable<decimal> ActualWeight { get; set; }
        public string FlightNumber { get; set; }
        public string DateOfArrival { get; set; }
        public string IgmDate { get; set; }
        public string TimeOfArrival { get; set; }
        public Nullable<long> CourierCoId { get; set; }
        public string CourierCoName { get; set; }
        public Nullable<int> AirlineId { get; set; }
        public string AirportDesc { get; set; }
    }
}
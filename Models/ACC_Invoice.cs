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
    
    public partial class ACC_Invoice
    {
        public long InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> PeriodFrom { get; set; }
        public Nullable<System.DateTime> PeriodTo { get; set; }
        public Nullable<int> InvoiceTypeId { get; set; }
        public Nullable<long> CourierCoId { get; set; }
        public Nullable<decimal> FacilitationChrgs { get; set; }
        public Nullable<decimal> FacilitationAmt { get; set; }
        public Nullable<decimal> ScreenAirlineChrgs { get; set; }
        public Nullable<decimal> ScreenAirlineAmt { get; set; }
        public Nullable<decimal> ScreenEICIChrgs { get; set; }
        public Nullable<decimal> ScreenEICIAmt { get; set; }
        public Nullable<decimal> CustomCostRcvrChrgs { get; set; }
        public Nullable<decimal> CustomCostRcvrAmt { get; set; }
        public Nullable<decimal> CustomSixtyPayChrgs { get; set; }
        public Nullable<decimal> CustomSixtyPayAmt { get; set; }
        public Nullable<decimal> ServiceTaxChrgs { get; set; }
        public Nullable<decimal> ServiceTaxAmt { get; set; }
        public Nullable<decimal> PrimaryCessChrgs { get; set; }
        public Nullable<decimal> PrimaryCessAmt { get; set; }
        public Nullable<decimal> SecondaryCessChrgs { get; set; }
        public Nullable<decimal> SecondaryCessAmt { get; set; }
        public Nullable<decimal> UserAccessArea { get; set; }
        public Nullable<decimal> UserAccessChrgs { get; set; }
        public Nullable<decimal> UserAccessAmt { get; set; }
        public Nullable<decimal> MemberShipFees { get; set; }
        public Nullable<decimal> EntranceFees { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> ReceivedAmount { get; set; }
        public string OutstandingStatus { get; set; }
        public string Remarks { get; set; }
        public string TerminalCode { get; set; }
        public Nullable<int> FinYear { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
        public Nullable<decimal> SwachhBharatCessChrgs { get; set; }
        public Nullable<decimal> SwachhBharatCessAmt { get; set; }
        public Nullable<decimal> ImportChargesChrgs { get; set; }
        public Nullable<decimal> ImportChargesAmt { get; set; }
        public string ImportChargesName { get; set; }
        public Nullable<decimal> ExportChargesChrgs { get; set; }
        public Nullable<decimal> ExportChargesAmt { get; set; }
        public string ExportChargesName { get; set; }
    }
}

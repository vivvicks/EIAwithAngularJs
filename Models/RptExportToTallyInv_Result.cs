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
    
    public partial class RptExportToTallyInv_Result
    {
        public string InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceType { get; set; }
        public string CourierCoTallyName { get; set; }
        public decimal FacilitationAmt { get; set; }
        public string ExpFacilitationAccount { get; set; }
        public string ImpFacilatationAccount { get; set; }
        public Nullable<decimal> XRayCharges { get; set; }
        public string ExpXRayChrgAccount { get; set; }
        public decimal CustomCostRcvrAmt { get; set; }
        public string ExpCustomCostAccount { get; set; }
        public string ImpCustomCostAccount { get; set; }
        public decimal CustomSixtyPayAmt { get; set; }
        public string ExpCustomSixtyPayAccount { get; set; }
        public string ImpCustomSixtyPayAccount { get; set; }
        public decimal UserAccessAmt { get; set; }
        public string UserAccessFeesAccount { get; set; }
        public decimal MemberShipFees { get; set; }
        public string MemberShipFeesAccount { get; set; }
        public Nullable<decimal> ServiceTaxAmt { get; set; }
        public string ServiceTaxAccount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Remarks { get; set; }
        public string TerminalName { get; set; }
        public decimal SwachhBharatCessAmt { get; set; }
        public string SwachhBharatAccount { get; set; }
        public decimal ImportChargesAmt { get; set; }
        public string ImportChargesAccount { get; set; }
        public decimal ExportchargesAmt { get; set; }
        public string ExportChargesAccount { get; set; }
    }
}
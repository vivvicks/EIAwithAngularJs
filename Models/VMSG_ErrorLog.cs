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
    
    public partial class VMSG_ErrorLog
    {
        public long MESSAGE_ID { get; set; }
        public string From_Id { get; set; }
        public string MESSAGE_BODY { get; set; }
        public Nullable<System.DateTime> Submit_Date { get; set; }
        public Nullable<System.DateTime> Processed_Date { get; set; }
        public Nullable<long> ALERT_ID { get; set; }
        public Nullable<System.DateTime> RUNTIME { get; set; }
        public Nullable<int> PRIORITY { get; set; }
        public string CC_VALUE { get; set; }
        public string BCC_VALUE { get; set; }
        public string TO_Id { get; set; }
        public string MESSAGE_SUBJECT { get; set; }
        public string ATTACHMENT { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string DELIVERY_STATUS { get; set; }
        public Nullable<long> RELATION_ID { get; set; }
        public string STATUS { get; set; }
        public string SENSITIVITY { get; set; }
        public Nullable<System.DateTime> DO_NOT_SEND_DATE { get; set; }
    }
}

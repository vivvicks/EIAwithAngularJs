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
    
    public partial class M_UploadFile_MST
    {
        public long FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Module { get; set; }
        public string TransactionId { get; set; }
        public string TerminalCode { get; set; }
        public string FinantcialYear { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
    }
}
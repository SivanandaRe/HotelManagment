//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentaionLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblInventry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> PRODUCTID { get; set; }
        public int QTY { get; set; }
        public string UNITS { get; set; }
        public Nullable<int> CUSTOMERID { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}

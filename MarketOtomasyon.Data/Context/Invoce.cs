//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketOtomasyon.Data.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoce
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PurchaseOrderId { get; set; }
        public Nullable<bool> IsPayed { get; set; }
    
        public virtual Customers Customers { get; set; }
    }
}

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
    
    public partial class PurchaseOrderDetail
    {
        public int PurchaseOrderDetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int PurchaseOrderId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> QuantitySumPrice { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual PurchaseOrderDetail PurchaseOrderDetail1 { get; set; }
        public virtual PurchaseOrderDetail PurchaseOrderDetail2 { get; set; }
    }
}
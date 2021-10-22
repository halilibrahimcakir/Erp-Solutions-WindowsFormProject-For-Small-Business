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
    
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }
    
        public int PurchaseOrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<bool> IsApporeved { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> PurchaseOrderStatusId { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual PurchaseOrderStatus PurchaseOrderStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
    }
}
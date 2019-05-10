using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TubzeeFullStack
{
    public partial class Supplier
    {
        public Supplier()
        {
            //PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public int SupplierId { get; set; }
        public int SupplierTypeId { get; set; }
        public int AddressTypeId { get; set; }
        public int TownId { get; set; }
        [Display(Name = "Name")]
        public string SupplierName { get; set; }
        [Display(Name = "Add 1")]
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Display(Name = "Sort Code")]
        public string BankSortCode { get; set; }
        [Display(Name = "Account No")]
        public string BankAccountNo { get; set; }

        [ForeignKey("TownId")]
        public virtual Town Town { get; set; }
        //public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}

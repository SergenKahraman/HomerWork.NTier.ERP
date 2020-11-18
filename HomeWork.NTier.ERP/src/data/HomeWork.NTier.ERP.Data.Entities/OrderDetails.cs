using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.NTier.ERP.Data.Entities
{
    [Table("Order Details")]
    public class OrderDetails //TODO: burada iki tane primaryKey olduğu için Column attribute larini kullandık
    {
        [Key]
        [Column(Order = 0)]
        public int OrderID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
    }
}


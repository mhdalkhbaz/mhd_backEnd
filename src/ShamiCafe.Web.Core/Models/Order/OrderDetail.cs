using ShamiCafe.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShamiCafe.Models.Order
{
    public class OrderDetail : BaseEntity<int>
    {
        public int MaterialId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Inventory { get; set; }

        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

    }
}

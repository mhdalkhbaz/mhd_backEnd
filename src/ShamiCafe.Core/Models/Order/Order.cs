using ShamiCafe.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShamiCafe.Models.Common.Enum.Enum;

namespace ShamiCafe.Models.Order
{
    public class Order : AuditableEntity<int>
    {
        public string BranchName { get; set; }
        public string UserName { get; set; }


        public OrderStatus? OrderStatus { get; set; }
       
        public ICollection<OrderDetail> OrderDetails { get; set; }


        public static string[] GetIncludeAll()
        {
            return new string[] { nameof(OrderDetails) };
        }
    }


}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string? ProductName { get; set; }
        public int?  Qty { get; set; }
        public int? UnitPrice { get; set; }
        public int? TotalPrice { get; set; }

        public int CustomerId { get; set; }

        public Customer?  Customer { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string? customName { get; set; }    
        public string? email { get; set; }
        public long? contactNO  { get; set; }
        public string? location { get; set; }

        public List<Order>? Orders { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Sales.Models
{
    [Table("EmployeTable")]
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public int  Age { get; set; }

        public string? EmpName { get; set; }

        public string? Gender { get; set; }

        public string? location { get; set; }

        public int? Salary{ get; set; }

        

    }
}

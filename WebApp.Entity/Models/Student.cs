using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Entity.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; } 
        public string? StudentName { get; set; }

        public string? StudentEmail { get; set; }

    }
}

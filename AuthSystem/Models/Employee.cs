using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string EmployeeCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string OfficeLocation { get; set; }

    }
}

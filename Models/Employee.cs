using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.nerMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Employee Code")]
        public string Emp_Code { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Employee Postion")]
        public string Postion { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }
    }
}

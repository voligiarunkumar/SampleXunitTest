using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Employee ID")]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Name of the Employee")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MaxLength(80, ErrorMessage = "{0} can contain a maximum of {1} characters")]
        [MinLength(2, ErrorMessage = "{0} should contain a minimum of {1} characters")]
        public string EmployeeName { get; set; }


        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }


        [Range(minimum: 0, maximum: 200000, ErrorMessage = "{0} has to be between {1} and {2}")]
        public decimal? Salary { get; set; }


        [Display(Name = "Is Employee allowed to login?")]
        public bool IsEnabled { get; set; }
    }
}

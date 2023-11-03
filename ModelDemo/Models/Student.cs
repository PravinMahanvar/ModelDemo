using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelDemo.Models
{
    public class Student
    {
       
        
            [Required(ErrorMessage = "RollNo is required")]
            [Display(Name = "Std RollNo")]
            public int RollNo { get; set; }

            [Required(ErrorMessage = "Name is required")]
            [Display(Name = "Student Name")]
            [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
            [MinLength(2)]
            public string? Name { get; set; }

            [Required]
            [Display(Name = "Std Percentage")]
            public double Percentage { get; set; }

            [Required]
            public int Age { get; set; }

            [Display(Name = "Date of Birth")]
            [DataType(DataType.Date)]
            public DateTime Dob { get; set; }

            public string? City { get; set; }

            [Required(ErrorMessage = "Branch is required")]
            [Display(Name = "Branch Name")]
            public string? Branch { get; set; }



        
    }

}


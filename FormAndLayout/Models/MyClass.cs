using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormAndLayout.Models
{
    public class MyClass
    {
        [Required(ErrorMessage = "Please provide Name")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z.\-\s]+$", ErrorMessage = "Please provide a valid name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide Id")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "Id should be in 22-*****-* format")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please provide Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Provide Email")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}@student.aiub.edu+$", ErrorMessage = " Email should match with Id ")]
        public string Email { get; set; }






    }
}
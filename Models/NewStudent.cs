using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentLogin.Models
{
    public class NewStudent
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string Name { get; set; }

        // [Required]
        //[RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "Invalid date format. Please use yyyy-MM-dd.")]
        // public DateTime DOB { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DOB
        {
            get;
            set;
        }

        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(Male|Female)$", ErrorMessage = "Invalid gender. Valid values are 'Male' or 'Female'.")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Language can only contain letters and spaces.")]
        public string Lang { get; set; }
    }
}
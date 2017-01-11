using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthClinic.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="نام")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "نام پدر")]
        public string FathersName { get; set; }
        [Display(Name = "کد ملی")]
        public string NationalId { get; set; }
        [Display(Name = "تحصیلات")]
        public string Education { get; set; }
        [Display(Name = "تاریخ تولد")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "توضیحات")]
        public string Descriptions { get; set; }
        [Required]
        [Display(Name = "تاریخ اولین پذیرش")]
        public DateTime FirstReceptionDate { get; set; }
    }
}
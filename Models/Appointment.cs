using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthClinic.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "تاریخ ملاقات")]
        public DateTime AppointmentDateTime { get; set; }
        [Required]
        [Display(Name = "مراجع")]
        public Patient Attendee {get;set;}
        [Required]
        [Display(Name = "متخصص")]
        public Personnel Attendant { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthClinic.Models
{
    public class Report
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "ملاقات مربوطه")]
        public Appointment RelatedAppointment { get; set; }
        [Required]
        [Display(Name = "شماره صفحه")]
        public int PageNumber { get; set; }
        
        
        
        
        [Display(Name = "توضیحات")]
        public string Descriptions { get; set; }
        [Display(Name = "تصویر گزارش")]
        public string ImagePath { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public DateTime SubmissionDateTime { get; set; }
        [Display(Name = "ثبت کننده")]
        public Personnel Author { get; set; }
        [Display(Name = "آخرین تغییر دهنده")]
        public Personnel LastModifier { get; set; }
        [Display(Name = "تاریخ آخرین تغییر")]
        public DateTime LastModifiedDateTime { get; set; }

    }
}
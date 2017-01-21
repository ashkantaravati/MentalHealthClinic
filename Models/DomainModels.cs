using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MentalHealthClinic.Models
{
    public enum PersianMonth
    {
        فروردین=1,
        اردیبهشت,
        خرداد,
        تیر,
        مرداد,
        شهریور,
        مهر,
        آبان,
        آذر,
        دی,
        بهمن,
        اسفند
    }
    public class Patient
    {
        public int PatientID { get; set; }
        [Required]
        [Display(Name = "نام")]
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
        public string BirthDate { get; set; }
        [Display(Name = "توضیحات")]
        public string Descriptions { get; set; }
        //[Required]
        //[Display(Name = "تاریخ اولین پذیرش")]
        //public DateTime FirstReceptionDate { get; set; }
        [Required]
        [MaxLength(4),MinLength(4)]
        [Display(Name = "سال تشکیل پرونده")]
        public string YearOfFirstReception { get; set; }
        [Required]
        [Display(Name = "ماه تشکیل پرونده")]

        public PersianMonth MonthOfFirstReception { get; set; }

        
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
    public class Report
    {
        public int ReportID { get; set; }
        [Required]
        [Display(Name = "ملاقات مربوطه")]
        public virtual Appointment RelatedAppointment { get; set; }
        [Required]
        [Display(Name = "شماره صفحه")]
        public int PageNumber { get; set; }
        
        public int AppointmentID { get; set; }


        [Display(Name = "توضیحات")]
        public string Descriptions { get; set; }
        [Display(Name = "تصویر گزارش")]
        public string ImagePath { get; set; }
        
        public DateTime SubmissionDateTime { get; set; }
        //[Display(Name = "ثبت کننده")]
        //public Expert Author { get; set; }
        //[Display(Name = "آخرین تغییر دهنده")]
        //public Expert LastModifier { get; set; }
       
        public DateTime LastModifiedDateTime { get; set; }

    }
    //public enum PersonnelType
    //{
    //    Admin,
    //    Psychotherapist,
    //    Receptionist
    //};
    public class Expert
    {
        public int ExpertID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Descriptions { get; set; }

        public virtual ICollection<Appointment> Appointments {get;set;}
    }
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Required]
        [Display(Name = "تاریخ ملاقات")]
        public string AppointmentDateTime { get; set; }
        [Required]
        [Display(Name = "مراجع")]
        public virtual Patient Attendee { get; set; }
        public int PatientID { get; set; }
        [Required]
        [Display(Name = "متخصص")]
        public virtual Expert Attendant { get; set; }
        public int ExpertID { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

    }
    public enum Gender
    {
        آقای,
        خانم
    }
}
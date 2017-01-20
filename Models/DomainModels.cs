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
        Farvardin,
        Ordibehesht,
        Xordad,
        Tir,
        Mordad,
        Shahrivar,
        Mehr,
        Aban,
        Azar,
        Dey,
        Bahman,
        Esfand
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
        [Display(Name = "تاریخ ثبت")]
        public DateTime SubmissionDateTime { get; set; }
        [Display(Name = "ثبت کننده")]
        public Personnel Author { get; set; }
        [Display(Name = "آخرین تغییر دهنده")]
        public Personnel LastModifier { get; set; }
        [Display(Name = "تاریخ آخرین تغییر")]
        public DateTime LastModifiedDateTime { get; set; }

    }
    public enum PersonnelType
    {
        Admin,
        Psychotherapist,
        Receptionist
    };
    public class Personnel
    {
        public int PersonnelID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonnelType Type { get; set; }
        public string Descriptions { get; set; }

        public virtual ICollection<Appointment> Appointments {get;set;}
    }
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Required]
        [Display(Name = "تاریخ ملاقات")]
        public DateTime AppointmentDateTime { get; set; }
        [Required]
        [Display(Name = "مراجع")]
        public virtual Patient Attendee { get; set; }
        public int PatientID { get; set; }
        [Required]
        [Display(Name = "متخصص")]
        public virtual Personnel Attendant { get; set; }
        public int PersonnelID { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

    }
    public class ClinicDBContext : DbContext
    {
        public ClinicDBContext() : base("DefaultConnection")
        {

        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}
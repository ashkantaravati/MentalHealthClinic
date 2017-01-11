using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MentalHealthClinic.Models
{
    public class ClinicDBContext:DbContext
    {
       public ClinicDBContext():base("MentalHealthClinicDatabase")
        {

        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}
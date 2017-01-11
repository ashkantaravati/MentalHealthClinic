using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MentalHealthClinic.Models
{
    public class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum PersonnelType
        {
            Admin,
            Psychotherapist,
            Receptionist
        };
        public string Descriptions { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegHospital.Objects
{
    public class Patient
    {
        public int PatientId { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        [MaxLength(10)]
        public string Gender { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(16)]
        public string PolicyNumber { get; set; }

        ICollection<Appointment> Appointments { get; set; }

    }
}

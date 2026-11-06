using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegHospital.Objects
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
       
        [MaxLength(50)]
        public string VisitType { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegHospital.Objects
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        public int SpecialtieId { get; set; }
        public Specialtie Specialtie { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [MaxLength(200)]
        public string WorkShedule { get; set; }

        ICollection<Appointment> Appointments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegHospital.Objects
{
    public class Room
    {
        public int RoomId { get; set; }
        [MaxLength(10)]
        public string Number { get; set; }
        public int Floor { get; set; }
        [MaxLength(200)]
        public string Purpose { get; set; }

        ICollection<Doctor> Doctors { get; set; }
     
    }
}

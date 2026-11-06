using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegHospital.Objects
{
    public class Specialtie
    {
        public int SpecialtieId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        ICollection<Doctor> Doctors { get; set; }

    }
}

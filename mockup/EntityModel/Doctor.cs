using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.EntityModel
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string? DoctorName { get; set; }
        public string? Speciality { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}

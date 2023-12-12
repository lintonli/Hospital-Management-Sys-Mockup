using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.EntityModel
{
    public class AddAppointment
    {
       /* public int AppointmentID { get; set; }*/
        public DateOnly ? AppointmentDate { get; set; }
        public TimeOnly ? AppointmentTime { get; set; }
    }
}

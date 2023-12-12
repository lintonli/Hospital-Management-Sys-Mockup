using mockup.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Service.Iservices
{
    public interface IAppointment
    {
        List<Appointment> GetAppointments();
        Appointment GetAppointmentById(int AppointmentID);
        string AddAppointment(Appointment newAppointment);
        string DeleteAppointment(Appointment appointment);

    }
}

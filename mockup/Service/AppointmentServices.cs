using mockup.Data;
using mockup.EntityModel;
using mockup.Service.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Service
{
    public class AppointmentServices : IAppointment
    {
        private readonly AppDbContext _context;
        public AppointmentServices()
            {
            _context = new AppDbContext();
            }

        public string AddAppointment(Appointment newAppointment)
        {
            try {
                var response = _context.Add(newAppointment);
                _context.SaveChanges();
                return "Appointment was successfully Added";
            }
            catch (Exception ex)
            {
                return $"Error occured {ex.Message}"; 
            }
           
        }

        public string DeleteAppointment(Appointment appointment)
        {
            try
            {
                _context.Remove(appointment);
                _context.SaveChanges();
                return "";
            }
            catch(Exception ex)
            {
                return $"Error {ex.Message}";
            }
             
        }

        public Appointment GetAppointmentById(int AppointmentID)
        {
            try
            {
                var response = _context.Appointments.Find(AppointmentID);
                return response;

            }
            catch (Exception ex)
            {
                return new Appointment();
            }
           

        }

        public List<Appointment> GetAppointments()
        {
           var appointments = _context.Appointments;
            return appointments.ToList();

        }
    }
}

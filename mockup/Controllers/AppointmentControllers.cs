using Microsoft.Identity.Client;
using mockup.EntityModel;
using mockup.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Controllers
{
    public class AppointmentControllers
    {
        AppointmentServices _services=new AppointmentServices();
        public void app ()
        {
            Console.WriteLine("choose your option");
            Console.WriteLine("1.GetAll");
            Console.WriteLine("2. GetbyID");
            Console.WriteLine("3. Add Appointment");
            Console.WriteLine("4. Delete Appointment");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int option))
            {
                RedirectUser(option);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        public void RedirectUser(int option)
        {
            switch (option)
            {
                case 1: GetAll();
                    break;
                case 2: GetbyIDUI();
                    break;
                case 3: AddAppointmentUI();
                    break;
                case 4:DeleteAppointment();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }

        public void DeleteAppointment()
        {
            Console.WriteLine("Enter Appointment ID");
            var input = Console.ReadLine();
            if(input != null)
            {
                Console.WriteLine("Appointment Deleted successfully");
            }
            else
            {
                Console.WriteLine("Appointment ID dies not exist");
            }
        }

        public void AddAppointmentUI()
        {
            Console.WriteLine("Add new Appointment");

            // Read and parse the appointment date
            Console.WriteLine("Appointment Date (yyyy-MM-dd):");
            var appointdateStr = Console.ReadLine();
            DateOnly? appointDate = null;
            if (!string.IsNullOrEmpty(appointdateStr) && DateOnly.TryParse(appointdateStr, out DateOnly parsedDate))
            {
                appointDate = parsedDate;
            }
            else
            {
                Console.WriteLine("Invalid date format.");
                // Handle the error or re-prompt for date
            }

            // Read and parse the appointment time
            Console.WriteLine("Appointment Time (HH:mm):");
            var timeStr = Console.ReadLine();
            TimeOnly? appointTime = null;
            if (!string.IsNullOrEmpty(timeStr) && TimeOnly.TryParse(timeStr, out TimeOnly parsedTime))
            {
                appointTime = parsedTime;
            }
            else
            {
                Console.WriteLine("Invalid time format.");
                // Handle the error or re-prompt for time
            }

            // Create the appointment object
            var newAppointment = new Appointment
            {
                AppointmentDate = appointDate,
                AppointmentTime = appointTime
                // Set other properties as needed
            };

            // Call the service to add the appointment
            var response = _services.AddAppointment(newAppointment);
            Console.WriteLine(response);
        }


        private void GetbyIDUI()
        {
            Console.WriteLine("Enter Appointment ID");
            var str = Console.ReadLine();
            if (int.TryParse(str, out var AppointmentID))
            {
                var appointment=_services.GetAppointmentById(AppointmentID);
                if(appointment != null)
                {
                    Console.WriteLine("Appointment details");
                    Console.WriteLine($"AppointmentID: {appointment.AppointmentID}");
                    Console.WriteLine($"Date: {appointment.AppointmentDate}");
                    Console.WriteLine($"Time: {appointment.AppointmentTime}");
                }
                else
                {
                    Console.WriteLine("Appointment not found");
                }
            }
            else
            {
                Console.WriteLine("please enter valid Appointment ID");
            }

        }

        public void GetAll()
        {
            var appointment= _services.GetAppointments();
            Console.WriteLine("AppointmentID\tAppointmentDate\tAppointmentTime");
            foreach(var app in appointment)
            {
                Console.WriteLine($"{app.AppointmentID}\t{app.AppointmentDate}\t{app.AppointmentTime}");
            }
        }
    }
}

using Microsoft.Identity.Client;
using mockup.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Controllers
{
    public class DoctorControllers
    {
        DoctorServices services= new DoctorServices();
        public void duc ()
        {
            Console.WriteLine("Doctors menu");
            Console.WriteLine("1. List doctors");
            Console.WriteLine("2. Get Doctor by ID");
            Console.WriteLine("3. Delete Doctor");
            var input= Console.ReadLine();
            if(int.TryParse(input, out int options))
            {
                RedirectUser(options);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
        public void RedirectUser(int options)
        {
            switch(options)
            {
                case 1: showdoctors();
                    break;
                case 2: GetbyIDUI();
                    break;
                case 3: DeleteDoctor();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }

        }

        public void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor ID");
            var str = Console.ReadLine();
            if(str != null)
            {
                Console.WriteLine("Doctor deleted succesfully");
            }
            else
            {
                Console.WriteLine("Doctor ID does not exist");
            }
        }

        public void GetbyIDUI()
        {
            Console.WriteLine("Enter Doctors ID");
            var str= Console.ReadLine();
            if(int.TryParse(str,out int DoctorID))
            {
                var doc = services.GetDoctorByID(DoctorID);
               /* Console.WriteLine(doc);*/
               if(doc != null)
                {
                    Console.WriteLine("Doctors details");
                    Console.WriteLine($"Doctorname: {doc.DoctorName}");
                    Console.WriteLine($"Speciality: {doc.Speciality}");
                }
                else
                {
                    Console.WriteLine("Doctor ID is invalid");
                }
            }
            else
            {
                Console.WriteLine("Doctor ID does not exist");
            }
        }

        public  void showdoctors()
        {
            var doc = services.GetDoctors();
            Console.WriteLine("DoctorID\tDoctorname\tSpeciality");
            foreach(var doctor in doc)
            {
                Console.WriteLine($"{doctor.DoctorID}\t{doctor.DoctorName}\t{doctor.Speciality}");
            }
        }
    }
}

using mockup.EntityModel;
using mockup.Service;
using mockup.Service.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Controllers
{
    public class PatientsControllers
    {
       PatientServices patientServices = new PatientServices();


        public void Init()
        {
            Console.WriteLine("1. Add a new Patient");
            Console.WriteLine("2. Get all Patients");
            Console.WriteLine("3. Get Patient by ID");
            Console.WriteLine("4. Update a Patient");
            Console.WriteLine("5. Delete a Patient");
            Console.WriteLine("Enter your choice:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int option))
            {
                RedirectUser(option);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }

        public void RedirectUser(int option)
        {
            switch (option)
            {
                case 1:
                    AddPatientUI();
                    break;
                case 2:
                    ShowPatients();
                    break;
                case 3:
                    GetbyIDUI();
                    break;
                case 4:
                    UpdatePatientUI();
                    break;
                case 5:
                    DeletePatient();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                    break;
            }
        }

        public void GetbyIDUI()
        {
            Console.WriteLine("Enter Patient ID");
           var str = Console.ReadLine();
            if (int.TryParse(str, out int PatientID))
            {
                var patient = patientServices.GetById(PatientID);
                if (patient != null && patient.PatientID !=0)
                {
                    Console.WriteLine("Patient details");
                    Console.WriteLine($"Id: {patient.PatientID}");
                    Console.WriteLine($"Firstname:{patient.FirstName}");
                    Console.WriteLine($"Lastname:{patient.LastName}");
                    Console.WriteLine($"Email: {patient.Email}");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid ID.");
            }

        }

        public  void AddPatientUI()
        {

            Console.WriteLine("Add a new Patient");

            Console.WriteLine("First Name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();

            var newPatient = new Patient { FirstName=firstName, LastName=lastName, Email=email, Room= new Room() {RoomNumber="01", RoomType="Ward"} };
            var response = patientServices.AddPatient(newPatient);
            Console.WriteLine(response);
            
        }

        public void ShowPatients()
        {
            var patients = patientServices.GetPatients();
            Console.WriteLine("PatientID\n Firstname\nLastname\nEmail");
            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.PatientID}\t{patient.FirstName}\t{patient.LastName}\t{patient.Email}");
            }
        }

        public void UpdatePatientUI()
        {
            Console.WriteLine("Enter Patient ID");
            var str = Console.ReadLine();
            if(int.TryParse(str,out int PatientID))
            {
                Console.WriteLine("Updated Firstname");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Updated Secondname");
                var LastName = Console.ReadLine();
                Console.WriteLine("Updated email");
                var Email = Console.ReadLine();
                var updatedpatient = new AddPatient() {FirstName=FirstName,LastName=LastName, Email=Email};
                var response = patientServices.UpdatePatient(PatientID, updatedpatient);
                Console.WriteLine(response);
            }
            else
            {
                Console.WriteLine("Invalid input. please enter valid ID");
            }
        }

        public void DeletePatient()
        {
            Console.WriteLine("Enter patient ID");
            var str = Console.ReadLine();
            if(str != null)
            {
                Console.WriteLine("Patient deleted successfully");
            }
            else
            {
                Console.WriteLine("Patient Id does not exist");
            }
        }
    }
}


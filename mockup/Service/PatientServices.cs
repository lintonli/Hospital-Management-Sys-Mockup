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
    public class PatientServices : Ipatient

    {
        private readonly AppDbContext _context;

        public PatientServices()
        {
            _context = new AppDbContext();
        }

        public string AddPatient(Patient newPatient)
        {
            try
            {
                var response = _context.Add(newPatient);

                _context.SaveChanges();
                return "Patient successfully Added";
            }catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return "something went wrong when addingpatient";
            }
           
        }

        public string UpdatePatient(int PatientID, AddPatient UpdatePatient)
        {
            var response = _context.Patients.Update(GetById(PatientID));
            _context.SaveChanges();
            if(response != null)
            {
                return "patient updated successfully";
            }
            return "";
        }
        public string DeletePatient(int PatientID)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.PatientID == PatientID);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
                return $"Patient{patient.PatientID} deleted";
            }
            return "patient id does not exist";
        }

        public List<Patient> GetPatients()
        {
            var Pat = _context.Patients;
            return Pat.ToList();

        }

        public Patient GetById(int PatientID)
        {
            var response = _context.Patients.Find(PatientID);
            if (response == null)
            {
                return new Patient();
            }
            return response;
        }
    }
}

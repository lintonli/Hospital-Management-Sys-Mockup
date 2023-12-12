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
   
    public class DoctorServices : IDoctor
    {
        private readonly AppDbContext _context;
        public DoctorServices()
        {
            _context = new AppDbContext();
        }
            public string DeleteDoctor(int DoctorID)
        {
            var doctor = _context.Doctors.Where(x => x.DoctorID == DoctorID).FirstOrDefault();
            if (doctor != null)
            {

             _context.Doctors.Remove(doctor);   
            _context.SaveChanges();
             return $"Dr. {doctor.DoctorName} deleted successfully";
            }
            return "The doctor you are trying to delete could not be found";
        }

        public Doctor GetDoctorByID(int DoctorID)
        {
            try
            {
                var response = _context.Doctors.Find(DoctorID);
                return response;
            }
            catch (Exception ex)
            {
                return new Doctor();
            }
            
        }

        public List<Doctor> GetDoctors()
        {
            var doctor= _context.Doctors;
            return doctor.ToList();
        }
    }
}

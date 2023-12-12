using mockup.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Service.Iservices
{
    public interface Ipatient
    {
        List<Patient> GetPatients();
        Patient GetById(int PatientID);
        string AddPatient(Patient newPatient);
        String UpdatePatient( int PatientID, AddPatient UpdatePatient);
        string DeletePatient(int PatientID);

    }
}

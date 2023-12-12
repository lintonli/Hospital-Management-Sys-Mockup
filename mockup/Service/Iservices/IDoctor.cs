using mockup.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Service.Iservices
{
    public interface IDoctor
    {
        List<Doctor> GetDoctors();
        Doctor GetDoctorByID( int DoctorID);
        string DeleteDoctor(int DoctorID);

    }
}

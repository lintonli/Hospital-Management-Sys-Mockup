﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.EntityModel
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateOnly ? AppointmentDate {  get; set; }
        public TimeOnly ? AppointmentTime { get; set; }


        public int DoctorID {  get; set; }
        public Doctor Doctor { get; set; }

        public int PatientID {  get; set; }
        public  Patient Patient { get; set; }
    }
}

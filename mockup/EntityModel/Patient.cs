using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.EntityModel
{
    public  class Patient
    {
       
        public int PatientID {  get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public int RoomID {  get; set; }
        public Room? Room { get; set; }
      
    }
}

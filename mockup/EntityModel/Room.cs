using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.EntityModel
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string? RoomNumber {  get; set; }
        public string? RoomType {  get; set; }

        public ICollection<Patient>? Patients { get; set; }
    }
}

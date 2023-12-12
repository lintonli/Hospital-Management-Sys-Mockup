using mockup.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mockup.Controllers
{
    public class RoomControllers
    {
        RoomServices roomServices=new RoomServices();
        public void init()
        {
            Console.WriteLine("Rooms menu");
            Console.WriteLine("1. Get Rooms");
            Console.WriteLine("2. Show room by ID");
            var input= Console.ReadLine();

            if(int.TryParse(input,out int options))

            {
                RedirectUser(options);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        public void RedirectUser(int options)
        {
            switch (options)
            {
                case 1: GetRooms();
                    break;
                    case 2:GetbyID(); 
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }

        public void GetbyID()
        {
            Console.WriteLine("Enter room ID");
            var str = Console.ReadLine();
            if(int.TryParse(str, out int RoomID))
            {
                var room = roomServices.GetRoomByID(RoomID);
                Console.WriteLine(room);
            }
        }

        public void GetRooms()
        {
          var rooms = roomServices.GetRooms();
            Console.WriteLine("Roomid\tRoomnumber\tRoomtype");
            foreach(var room in rooms) 
            {
                Console.WriteLine($"Roomid{room.RoomID}\t Roomnumber{room.RoomNumber}\t Roomtype{room.RoomType}");
            }
        }
    }
}

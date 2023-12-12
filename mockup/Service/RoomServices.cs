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
    public class RoomServices : IRoom
    {
        private readonly AppDbContext _context;
        public RoomServices()
        {
            _context = new AppDbContext();
        }
        public Room GetRoomByID(int RoomID)
        {
            var response = _context.Rooms.Find(RoomID);
            if (response == null)
            {
                response = new Room();
            }
            return response;
        }

        public List<Room> GetRooms()
        {
            var room= _context.Rooms;
            return room.ToList();
        }
    }
}

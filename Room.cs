using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AE_Clinica
{
    class Room
    {
        private string roomNumber;
        private string floorOfTheRoom;
        private string spaceOfTheRoom;

        public Room(string roomNumber, string floorOfTheRoom, string spaceOfTheRoom)
        {
            this.roomNumber = roomNumber;
            this.floorOfTheRoom = floorOfTheRoom;
            this.spaceOfTheRoom = spaceOfTheRoom;
        }

        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string FloorOfTheRoom { get => floorOfTheRoom; set => floorOfTheRoom = value; }
        public string SpaceOfTheRoom { get => spaceOfTheRoom; set => spaceOfTheRoom = value; }
    }
}

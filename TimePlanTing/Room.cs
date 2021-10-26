using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Room
    {
        public string RoomName { get; private set; }
        public Session OngoingSession { get; private set; }
        public bool IsOccupied => OngoingSession != null;

        public Room(string roomName)
        {
            RoomName = roomName;
        }

        public void OccupyClassroom(Session s)
        {
            if(IsOccupied == true) return;
            OngoingSession = s;
        }
    }
}

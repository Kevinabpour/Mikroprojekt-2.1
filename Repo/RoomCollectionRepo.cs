using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public class RoomCollectionRepo : IRoomRepo
    {
        List<Room> _rooms = new List<Room>();
        public RoomCollectionRepo() // int roomID, string name, string description, int capacity, List<string> equipment
        {
            _rooms.Add(new Room(101, "room1", "description 1", 35, ["equipment1", "equipment2"]));
            _rooms.Add(new Room(102, "room2", "description 2", 10, ["equipment1", "equipment2"]));
            _rooms.Add(new Room(103, "room3", "description 3", 50, ["equipment1", "equipment2"]));
            _rooms.Add(new Room(104, "room4", "description 4", 20, ["equipment1", "equipment2"]));
        } 
        public List<Room> GetAll()
        {
            return _rooms;
        }

        public Room GetByID(int id)
        {
            foreach (Room room in _rooms)
            {
                if (room.RoomID == id)
                {
                    return room;
                }
            }
            return null;
        }
    }
}

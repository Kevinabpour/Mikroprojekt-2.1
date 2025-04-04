using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public class RoomCollectionRepo : IRoomRepo
    {
        List<Room> _rooms = new List<Room>();
        public RoomCollectionRepo() // int roomID, string name, string description, int capacity, List<string> equipment
        {
            _rooms.Add(new Room(101, "Alpha", "description 1", 35, ["Smartboard", "Forplejning"]));
            _rooms.Add(new Room(102, "Bravo", "description 2", 10, []));
            _rooms.Add(new Room(103, "Charlie", "description 3", 50, ["Smartboard"]));
            _rooms.Add(new Room(104, "Delta", "description 4", 20, ["Forplejning"]));
            _rooms.Add(new Room(105, "Echo", "description 5", 25, ["Smartboard"]));
            _rooms.Add(new Room(106, "Foxtrot", "description 6", 5, ["Smartboard", "Forplejning"]));
            _rooms.Add(new Room(107, "Golf", "description 7", 40, ["Smartboard", "Forplejning"]));
            _rooms.Add(new Room(108, "Hotel", "description 8", 500, ["Smartboard"]));
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

namespace Mikroprojekt_2.Model
{
    public class Room // Class for a rooom
    {
        public string RoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public List<string> Equipment { get; set; }

        public Room()
        {
            Name = "default name";
            Description = "default description";
            Capacity = 20;
            Equipment.Add("default equipment");

        }
        public Room(string roomID, string name, string description, int capacity, List<string> equipment)
        {
            RoomID = roomID;
            Name = name;
            Description = description;
            Capacity = capacity;
            Equipment = equipment;
        }

    }
}

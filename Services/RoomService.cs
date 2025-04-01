using Mikroprojekt_2.Repo;
using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Services
{
    public class RoomService
    {
        private IRoomRepo _roomRepo;

        public RoomService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public List<Room> GetAll()
        {
            return _roomRepo.GetAll();
        }

        public Room GetByID(int id)
        {
            return _roomRepo.GetByID(id);
        }

    }
}

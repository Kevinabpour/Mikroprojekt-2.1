using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public interface IRoomRepo
    {
        public List<Room> GetAll();
        public Room GetByID(int id);
    }
}

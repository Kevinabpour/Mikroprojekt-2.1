using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public interface IUserRepo
    {
        public User GetByID(int id);
        public void RemoveBooking(int userID, int bookingID);
        public void AddBooking(int userID, int bookingID);
    }
}

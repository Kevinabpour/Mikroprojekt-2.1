using Mikroprojekt_2.Model;
using Mikroprojekt_2.Repo;

namespace Mikroprojekt_2.Services
{
    public class UserService
    {
        private IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public User GetByID(int id)
        {
            return _userRepo.GetByID(id);
        }
        public void RemoveBooking(int userID, int bookingID)
        {
            _userRepo.RemoveBooking(userID, bookingID);
        }
        public void AddBooking(int userID, int bookingID)
        {
            _userRepo.RemoveBooking(userID, bookingID);
        }
    }
}

using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public class UserCollectionRepo : IUserRepo
    {
        List<User> _users = new List<User>();
        public UserCollectionRepo()
        {
            _users.Add(new User(001, "Mathias"));
            _users.Add(new User(002, "Christian"));
            _users.Add(new User(003, "Kevin"));
            _users.Add(new User(004, "Anas"));
        }


        public void AddBooking(int userID, int bookingID)
        {
            foreach (User user in _users)
            {
                if (user.UserID == userID)
                {
                    user.AddBooking(bookingID);
                }
            }
        }

        public User GetByID(int id)
        {
            foreach (User user in _users)
            {
                if (user.UserID == id)
                {
                    return user;
                }
            }
            return null;
        }

        public void RemoveBooking(int userID, int bookingID)
        {
            foreach (User user in _users)
            {
                if (user.UserID == userID)
                {
                    user.RemoveBooking(bookingID);
                }
            }
        }
    }
}

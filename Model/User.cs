namespace Mikroprojekt_2.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public List<int> BookingList { get; }

        public User()
        {

        }
        public User(int userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }

        public void AddBooking(int BookingNum)
        {
            BookingList.Add(BookingNum);
        }
        public void RemoveBooking(int BookingNum)
        {
        }

    }
}

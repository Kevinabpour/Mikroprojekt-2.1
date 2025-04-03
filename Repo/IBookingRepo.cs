using Mikroprojekt_2.Model;

namespace Mikroprojekt_2.Repo
{
    public interface IBookingRepo
    {
        public List<Booking> GetAll();
        public Booking GetByID(int id);
        public void RemoveBooking(int id);
        public void UpdateBooking(int id, string[] time, string comment);
    }
}

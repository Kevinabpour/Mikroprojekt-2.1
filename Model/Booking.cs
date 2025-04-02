namespace Mikroprojekt_2.Model
{
    public class Booking
    {
        public int BookingID { get; set; } // ID of the booking
        public int RoomID { get; set; } // ID for the room of the booking
        public int UserID { get; set; } // ID for the user who booked 
        public string Time { get; set; } // Timeframe of the booking mmHH-mmHH-dd
        public string Comment { get; set; } // Comment on the booking

        public Booking()
        {
        }
        public Booking(int bookingID, int roomID, int userID, string time, string comment)
        {
            BookingID = bookingID;
            RoomID = roomID;
            UserID = userID;
            Time = time;
            Comment = comment;
        }
    }
}

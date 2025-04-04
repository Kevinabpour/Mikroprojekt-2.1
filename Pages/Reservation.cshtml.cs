using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mikroprojekt_2.Model;
using Mikroprojekt_2.Services;

namespace Mikroprojekt_2.Pages
{
    public class ReservationModel : PageModel
    {
        private readonly ILogger<ReservationModel> _logger;
        public Room room { get; set; }
        public List<Room> Rooms { get; set; } // List of all rooms
        private RoomService _roomService;
        public List<Booking> Bookings { get; set; } // List of all bookings
        private BookingService _bookingService;

        public ReservationModel(ILogger<ReservationModel> logger, RoomService roomService, BookingService bookingService)
        {
            _logger = logger;
            Rooms = roomService.GetAll();
            _roomService = roomService;
            _bookingService = bookingService;
            Bookings = _bookingService.GetAll();
        }

        public void OnGet(int id)
        {
            room = _roomService.GetByID(id);
            
        }
        public IActionResult OnPost(int RoomID, string Day, string Time, string Comment, string Action)
        {
            string fullTime = $"{Time} {Day}";
            var allBookings = _bookingService.GetAll();
            var existing = allBookings.FirstOrDefault(b =>
                b.RoomID == RoomID &&
                b.Time.Contains(fullTime)
            );

            if (Action == "Book")
            {
                if (existing == null)
                {
                    var booking = new Booking
                    {
                        BookingID = new Random().Next(1000, 9999),
                        RoomID = RoomID,
                        UserID = 1,
                        Time = new[] { fullTime },
                        Comment = Comment
                    };

                    _bookingService.CreateBooking(booking);
                    TempData["Message"] = $"✅ Du har reserveret tiden {fullTime}.";
                }
                else
                {
                    TempData["Message"] = $"⚠️ Tiden {fullTime} er allerede reserveret.";
                }
            }
            else if (Action == "Cancel" && existing != null)
            {
                _bookingService.RemoveBooking(existing.BookingID);
                TempData["Message"] = $"❌ Du har aflyst din booking kl. {fullTime}.";
            }

            return RedirectToPage(new { id = RoomID });
        }



    }
}

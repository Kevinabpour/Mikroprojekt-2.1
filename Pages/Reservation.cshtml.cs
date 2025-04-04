using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mikroprojekt_2.Model;
using Mikroprojekt_2.Services;

namespace Mikroprojekt_2.Pages
{
    public class ReservationModel : PageModel
    {
        private readonly ILogger<ReservationModel> _logger;
        private RoomService _roomService;
        private BookingService _bookingService;

        public Room room { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Booking> Bookings { get; set; }

        public ReservationModel(ILogger<ReservationModel> logger, RoomService roomService, BookingService bookingService)
        {
            _logger = logger;
            _roomService = roomService;
            _bookingService = bookingService;
            Rooms = _roomService.GetAll();
        }

        public void OnGet(int id)
        {
            room = _roomService.GetByID(id);
            Bookings = _bookingService.GetAll();
        }

        public IActionResult OnPost(int RoomID, string Day, string Time, string MessageTarget, string Action)
        {
            string fullTime = $"{Time} {Day}";
            var bookings = _bookingService.GetAll();
            var existing = bookings.FirstOrDefault(b => b.RoomID == RoomID && b.Time.Contains(fullTime));

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
                        Comment = ""
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

            TempData["MessageTarget"] = MessageTarget;

            return RedirectToPage(new { id = RoomID });
        }
    }
}

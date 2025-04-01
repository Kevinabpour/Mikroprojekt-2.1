using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mikroprojekt_2.Model;
using Mikroprojekt_2.Services;

namespace Mikroprojekt_2.Pages
{
    public class BookingcshtmlModel : PageModel
    {
        private readonly ILogger<BookingcshtmlModel> _logger;

        public List<Room> Rooms { get; set; } // List of all rooms
        private RoomService _roomService;

        public BookingcshtmlModel(ILogger<BookingcshtmlModel> logger, RoomService roomService)
        {
            _logger = logger;
            Rooms = roomService.GetAll();
            _roomService = roomService;
        }


        public void OnGet()
        {
        }
    }
}

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

        public ReservationModel(ILogger<ReservationModel> logger, RoomService roomService)
        {
            _logger = logger;
            Rooms = roomService.GetAll();
            _roomService = roomService;
        }

        public void OnGet(int id)
        {
            room = _roomService.GetByID(id);
        }
    }
}

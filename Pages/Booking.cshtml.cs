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
    
   [BindProperty]
        public string FilterChoice { get; set; } // This will hold the selected filter

        public void OnPost()
        {
            var allRooms = _roomService.GetAll();

            switch (FilterChoice)
            {
                case "Smartboard/Projektor":
                    Rooms = allRooms.Where(r => r.Equipment.Contains("Smartboard")).ToList();
                    break;

                case "Forplejning":
                    Rooms = allRooms.Where(r => r.Equipment.Contains("Forplejning")).ToList();
                    break;

                case "5-10 personer":
                    Rooms = allRooms.Where(r => r.Capacity >= 5 && r.Capacity <= 10).ToList();
                    break;

                case "10-25 personer":
                    Rooms = allRooms.Where(r => r.Capacity >= 10 && r.Capacity <= 25).ToList();
                    break;

                case "25-40 personer":
                    Rooms = allRooms.Where(r => r.Capacity >= 25 && r.Capacity <= 40).ToList();
                    break;

                case "40-500 personer":
                    Rooms = allRooms.Where(r => r.Capacity >= 40 && r.Capacity <= 500).ToList();
                    break;

             
            }
        }
    }
}
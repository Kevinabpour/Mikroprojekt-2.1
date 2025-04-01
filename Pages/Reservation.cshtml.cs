using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mikroprojekt_2.Pages
{
    public class ReservationModel : PageModel
    {
        public int RoomID { get; set; }



        public void OnGet(int id)
        {
            RoomID = id;
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc.Rendering; //dodaje se kada izaberemo SelectListItem

using System.Web;

namespace HotelTest2.Models
{
	public class Rooms
	{
		public int RoomID { get; set; }
		public string RoomNumber { get; set; }
		public string RoomImage { get; set; }
		public int RoomPrice { get; set; }
		public int BookingStatusID { get; set; }
		public int RoomTypeID { get; set; }
		public int RoomCapacity { get; set; }

		public IFormFile Image { get; set; } //Posto nece da se iskoristi HttpPostFileBase, radi iskljucivo i samo za Windows, u MacOS, zamena mu je IFormFile
        //IFormFile je interfejs koji je dostupan u okviru ASP.NET Core i koji predstavlja fajl koji je poslat putem HTTP zahteva. Ovaj interfejs se koristi za obradu fajl uploada u veb aplikacijama



        public string RoomDescription { get; set; }

		public List<SelectListItem> ListOfBookingStatus { get; set; }

		public List<SelectListItem> ListOfRoomTypes { get; set; }

	}

    
}


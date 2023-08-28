using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelTest2.Models
{
	public class Hotel
	{
		public int HotelID { get; set; }
		public string RoomNumber { get; set; }
		public string RoomImage { get; set; }
		public int RoomPrice { get; set; }
		public int BookingStatusID { get; set; }
		public int RoomTypeID { get; set; }
		public int RoomCapacity { get; set; }
		public string RoomDescription { get; set; }
	}
}


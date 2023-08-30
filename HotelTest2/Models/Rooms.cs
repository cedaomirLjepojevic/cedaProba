using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering; //dodaje se kada izaberemo SelectListItem

namespace HotelTest2.Models
{
	public class Rooms
	{
        [Key]
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}


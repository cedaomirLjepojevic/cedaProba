using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HotelTest2.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

    }
}
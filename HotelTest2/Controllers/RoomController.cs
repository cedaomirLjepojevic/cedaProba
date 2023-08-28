using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//Ovo je samo test

namespace HotelTest2.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        //Dodavanje CRUDa 
=======

        public IActionResult Create()
        {
            return View();
        }
>>>>>>> cedaBranch
    }
}
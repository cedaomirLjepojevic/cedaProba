using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelTest2.Models;
using HotelTest2.Data;

//Ovo je samo test

namespace HotelTest2.Controllers
{
    public class RoomController : Controller
    {

        //private HotelDBEntities objHotelDbEntities;
        private readonly ApplicationDbContext _context;

        //konstruktor
        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }


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
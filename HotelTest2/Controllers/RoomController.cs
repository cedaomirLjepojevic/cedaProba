using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelTest2.Data;
using Microsoft.AspNetCore.Mvc;
using HotelTest2.Models;

namespace HotelTest2.Controllers
{
    public class RoomController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        public RoomController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var soba = _dbContext.rooms.ToList();
            return View(soba);
        }
    }
}
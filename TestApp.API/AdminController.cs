using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.API.Data;

namespace TestApp.API
{
    public class AdminController : Controller
    {
		ApplicationDbContext _context;
		public AdminController(ApplicationDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
			var users = _context.Users.ToList();
            return View(users);
        }
    }
}
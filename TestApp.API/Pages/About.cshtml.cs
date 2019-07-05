using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApp.API.Data;

namespace TestApp.API.Pages
{
    public class AboutModel : PageModel
    {
		ApplicationDbContext _context;
		public AboutModel(ApplicationDbContext context)
		{
			_context = context;
		}
        public string Message { get; set; }

		public List<IdentityUser> Users { get; set; }

		public void OnGet()
        {
			Users = _context.Users.ToList();
            Message = "Your application description page.";
        }
    }
}

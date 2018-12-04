using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Probafeladat.Data;
using Probafeladat.Models;

namespace Probafeladat.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SearchController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string key)
        {            
            if (key == null)
            {
                return View(new List<Package>());
            }

            string searchKey = key.ToUpper();
            var currentUserID = _userManager.GetUserId(HttpContext.User);                       
            
            var applicationDbContext = _context.Packages
                .Include(p => p.ShippingState)
                .Include(p => p.User)
                .Where(p => p.Identifier.Contains(searchKey))
                .Where(p => p.User.Id == currentUserID);
            return View(await applicationDbContext.ToListAsync());
        }        
    }
}

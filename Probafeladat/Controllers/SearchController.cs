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
        public async Task<IActionResult> Index(string key)
        {
            var currentUserID = _userManager.GetUserId(HttpContext.User);
                       
            string searchKey = key.ToUpper();
            var applicationDbContext = _context.Packages
                .Include(p => p.ShippingState)
                .Include(p => p.User)
                .Where(p => p.Identifier.Contains(searchKey))
                .Where(p => p.User.Id == currentUserID);
            return View(await applicationDbContext.ToListAsync());
        }        
    }
}

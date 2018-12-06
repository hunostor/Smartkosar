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
using Probafeladat.ViewDTO;

namespace Probafeladat.Controllers
{
    [Authorize]
    public class MyPackagesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public MyPackagesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: MyPackages
        public ActionResult Index()
        {
            var currentUserId = _userManager.GetUserId(HttpContext.User);

            MyPackages myPackages = new MyPackages();
            myPackages.Packages = _context.Packages
                .Include(p => p.ShippingState)
                .Where(p => p.User.Id == currentUserId)
                .ToList();

            myPackages.ShippingStates = _context.ShippingStates.ToList();

            return View(myPackages);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var currentUserId = _userManager.GetUserId(HttpContext.User);

            var package = _context.Packages
                .Include(u => u.User)
                .Include(u => u.ShippingState)
                .SingleOrDefault(p => p.ID == id);           

            if (package == null || package.User.Id != currentUserId)
            {
                return NotFound();
            }

            return View(package);
        }
    }
}

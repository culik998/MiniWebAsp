using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniWebApp.Controllers
{
    public class HomeController:Controller
    {

        public UserDbContext _userDbContext { get; set; }

        public HomeController(UserDbContext userDbContext)
        {
            this._userDbContext = userDbContext;
        }


        public IActionResult Index()
        {
            return View(_userDbContext.Users.Include(m => m.Name).ToListAsync());
        }

    
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                await _userDbContext.Users.AddAsync(user);
                await _userDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(user));
            }
            

            return View();
        }



    }
}

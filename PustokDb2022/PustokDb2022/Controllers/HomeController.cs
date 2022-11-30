using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokDb2022.DAL;
using PustokDb2022.Models;
using PustokDb2022.ViewModels;
using System.Diagnostics;

namespace PustokDb2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;


        public HomeController(PustokDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeViewModel viewModel = new HomeViewModel
            {
                SpecialBooks = _context.Books.Include(x => x.Authors).Where(x => x.IsSpecial).Take(20).ToList(),
                NewBooks = _context.Books.Include(x => x.Authors).Where(x => x.IsNew).Take(20).ToList(),
                DiscountedBooks = _context.Books.Include(x => x.Authors).Where(x => x.DisCountPercent>0).Take(20).ToList(),
                Sliders = _context.Sliders.ToList(),
            };
            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
using freelancer_K205.Data;
using freelancer_K205.Models;
using freelancer_K205.ViewModel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace freelancer_K205.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FreeLancerDbContext _context;
        public HomeController(ILogger<HomeController> logger,FreeLancerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                Masthead = _context.Mastheads.FirstOrDefault(),
                Portfolios = _context.Portfolios.ToList(),
                Abouts = _context.Abouts.ToList()


            };

            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
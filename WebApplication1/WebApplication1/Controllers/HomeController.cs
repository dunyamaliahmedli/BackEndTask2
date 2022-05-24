using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        //public IActionResult Index()
        //{
        //    List<Slider> sliders = _context.Sliders.ToList();

        //    return View(sliders);
        //}
        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm()
            {

                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Products = await _context.Products.Include(p => p.ProductImages).Include(p => p.Category).Take(10).ToListAsync()

            };

            return View(homeVm);
        }



    }
}

﻿
using FiorelloBack.DAL;
using FiorelloBack.Models;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace FiorelloBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                HeaderSliders = _context.HeaderSliders.ToList(),
                settings = _context.settings.ToList(),
                Positions = _context.Positions.Include(x => x.FlowerExperts).ToList(),
                FooterSliders = _context.FooterSliders.ToList(),
            };
            return View(homeVm);

        }
    }
}

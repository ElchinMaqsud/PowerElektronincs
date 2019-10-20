using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using FinalProject.Db;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinalProject_Db _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(FinalProject_Db context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await _roleManager.RoleExistsAsync("İstifadəçi"))
            {
                await _roleManager.CreateAsync(new IdentityRole("İstifadəçi"));
            }

            ApplicationUser customUserFromDb = await _userManager.FindByNameAsync("admin");
            if (customUserFromDb == null)
            {
                ApplicationUser customUser = new ApplicationUser
                {
                    Firstname = "Admin",
                    Lastname = "Admin",
                    UserName = "admin",
                    Email = "powerElectronics.az@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "811-33-17",
                    PhotoUrl = "admin.png",
                    OperatorId = 4,
                };

                IdentityResult result = await _userManager.CreateAsync(customUser, "Power1234@");
                await _userManager.AddToRoleAsync(customUser, "Admin");
            }
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.ToList(),
                Smartphones = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Telefon" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList(),
                Tabs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Planşet" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList(),
                Notebooks = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Notbuk" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList(),
                Tvs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Televizor" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList(),
                Smartwatchs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "SmartWatch" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList(),
                Announcements = _context.Announcements.OrderByDescending(a => a.AddDate).ToList(),

            };
            ViewBag.Categories = _context.Categories;
            ViewBag.Marks = _context.Marks;
            return View(homeVM);
        }

        public IActionResult SmartPhones()
        {
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.Where(m=>m.CategoryId==1).ToList(),
                Smartphones = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Telefon" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList()
            };
            return View(homeVM);
        }

        public IActionResult Tabs()
        {
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.Where(m => m.CategoryId == 2).ToList(),
                
                Tabs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Planşet" && ads.IsConfirmed == true).OrderByDescending(s => s.AddDate).ToList()

            };
          
            return View(homeVM);
        }

        public IActionResult Notebook()
        {
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.Where(m => m.CategoryId == 3).ToList(),
                Notebooks = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Notbuk" && ads.IsConfirmed==true).OrderByDescending(s => s.AddDate).ToList(),

            };
            return View(homeVM);
        }

        public IActionResult TabLoader(int id)
        {
            List<Announcement> announcements = _context.Announcements.Where(ad => ad.Model.MarkId == id).OrderByDescending(s => s.AddDate).ToList();

            return PartialView("_AnouncementPartialView", announcements);
        }
        public IActionResult SmartphoneLoader(int id)
        {
            List<Announcement> announcements = _context.Announcements.Where(ad => ad.Model.MarkId == id).OrderByDescending(s => s.AddDate).ToList();

            return PartialView("_AnnouncementSmartphonePartialView", announcements);
        }

        public IActionResult LaptopLoader(int id)
        {
            List<Announcement> announcements = _context.Announcements.Where(ad => ad.Model.MarkId == id).OrderByDescending(s => s.AddDate).ToList();

            return PartialView("_AnnouncementLaptopPartialView", announcements);
        }

        public IActionResult TvLoader(int id)
        {
            List<Announcement> announcements = _context.Announcements.Where(ad => ad.Model.MarkId == id).OrderByDescending(s => s.AddDate).ToList();

            return PartialView("_AnnouncementLaptopPartialView", announcements);
        }
        public IActionResult SmartwatchLoader(int id)
        {
            List<Announcement> announcements = _context.Announcements.Where(ad => ad.Model.MarkId == id).OrderByDescending(s => s.AddDate).ToList();

            return PartialView("_AnnouncementSmartwatchPartialView", announcements);
        }



        public IActionResult Tv()
        {
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.Where(m => m.CategoryId == 4).ToList(),
                Tvs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "Televizor"&& ads.IsConfirmed==true).OrderByDescending(s => s.AddDate).ToList(),

            };
            return View(homeVM);
        }
        public IActionResult Smartwatch()
        {
            HomeVM homeVM = new HomeVM()
            {
                Marks = _context.Marks.Where(m => m.CategoryId == 5).ToList(),
                Smartwatchs = _context.Announcements.Where(ads => ads.Model.Mark.Category.Name == "SmartWatch"&& ads.IsConfirmed==true).OrderByDescending(s => s.AddDate).ToList()

            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult News()
        {
            return View(_context.News);
        }
        public async Task<IActionResult> NewsDetails(int? id)
        {

            if (id == null) return RedirectToAction("Error","Home");

            News selectedNews = await _context.News.FindAsync(id);

            if (selectedNews == null) RedirectToAction("Error", "Home");

            return View(selectedNews);
        }
        public  IActionResult AdsDetails(int? id)
        {
            Announcement selectedAds = _context.Announcements.FirstOrDefault(a=>a.Id==id);
            selectedAds.AnnouncementCount++;
            _context.SaveChanges();
          

            return View(selectedAds);
        }
        



    }
}
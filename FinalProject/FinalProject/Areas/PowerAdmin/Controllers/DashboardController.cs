using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using FinalProject.Db;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FinalProject.Areas.PowerAdmin.Controllers
{
    [Area("PowerAdmin")]
    

    public class DashboardController : Controller
    {
        private readonly FinalProject_Db _context;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public DashboardController(FinalProject_Db context, UserManager<ApplicationUser> userManager,IHostingEnvironment env,SignInManager<ApplicationUser> signInManager,IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _configuration = configuration;
        }


        public async Task<IActionResult> AdminLogin()
        {
            if (User.Identity.IsAuthenticated) {
                ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    if (!await _userManager.IsInRoleAsync(user, "Admin"))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
            }
           
          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminLogin(LoginVM admin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
                return View(admin);
            }

            ApplicationUser user = await _userManager.FindByNameAsync(admin.UserName);

           
            if (user == null)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
                return View(admin);
            }
            if (user.UserName != admin.UserName)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
            }

            if (!await _userManager.IsInRoleAsync(user, "Admin"))
            {

                return NotFound();
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, admin.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
                return View(admin);
            }

            return RedirectToAction("Index", "Dashboard");

        }

        public IActionResult LogOutAdmin()
        {
            if (User.Identity.IsAuthenticated)
            {
                _signInManager.SignOutAsync();
            }
            return RedirectToAction("AdminLogin", "Dashboard");
        }
        public IActionResult Index()
        {
                if (User.Identity.IsAuthenticated)
                {
                    AdminPropertiesVM propertiesVM = new AdminPropertiesVM()
                    {
                        Announcements = _context.Announcements.ToList(),
                        Users = _context.Users.ToList(),
                        Models = _context.Models.ToList()
                    };
                    return View(propertiesVM);
                }
            
            return RedirectToAction("AdminLogin","Dashboard");

        }

        public IActionResult ConfirmedAnnouncements()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            return View(_context.Announcements.Where(a=> a.IsConfirmed==true).ToList());
        }
        public IActionResult DontConfirmedAnnouncements()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            return View(_context.Announcements.Where(a => a.IsConfirmed == false).ToList());
        }

        public IActionResult AdsDetails(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            Announcement selectedAds = _context.Announcements.FirstOrDefault(a => a.Id == id);


            return View(selectedAds);
        }
        public async Task<IActionResult> ConfirmAnnouncement(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            Announcement selectedAds = _context.Announcements.FirstOrDefault(a => a.Id == id);
            selectedAds.IsConfirmed = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"], _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("powerElectronics.az@gmail.com", selectedAds.User.Email);
            message.IsBodyHtml = true;
            message.Subject = "Elan Təsdiqi";
            message.Body = $"<h1>Sizin Elanınız Təsdiqləndi.Təşəkkürlər</h1>";
            await client.SendMailAsync(message);

            await _context.SaveChangesAsync();


            return RedirectToAction("DontConfirmedAnnouncements","Dashboard");
        }
        public async Task<IActionResult> DeleteWrongAds(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            Announcement selectedAds = _context.Announcements.FirstOrDefault(a => a.Id == id);

            _context.Announcements.Remove(selectedAds);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"], _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("powerElectronics.az@gmail.com", selectedAds.User.Email);
            message.IsBodyHtml = true;
            message.Subject = "Elan Təsdiqi";
            message.Body = $"<h1 class='btn btn-danger'>Elanınızın məlumatları doğru olmadığından sizin elan təsdiqlənmədi</h1>";
            await client.SendMailAsync(message);

            await _context.SaveChangesAsync();

            return RedirectToAction("DontConfirmedAnnouncements", "Dashboard");
        }

        public IActionResult News()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            return View(_context.News.ToList());
        }
        public IActionResult NewsDetails(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            if (id == null) return RedirectToAction("Error","Home");
            News selectedNews = _context.News.Find(id);

            return View(selectedNews);
        }
        [HttpGet]
        [ActionName("CreateNews")]
        public IActionResult CreateNewsGet()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("CreateNews")]
        public async Task<IActionResult> CreatePost(News creatingNews)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bütün dəyərləri daxil edin!");
                return View(creatingNews);
            }

            if (creatingNews.Photo == null)
            {
                ModelState.AddModelError("Photo", "Xəbərin şəklin yükləyin");
                return View(creatingNews);
            }

            if (creatingNews.Photo.ContentType.Contains("image/"))
            {
                string folderPath = Path.Combine(_env.WebRootPath, "img");
                string fileName = Guid.NewGuid().ToString() + "_" + creatingNews.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);


                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await creatingNews.Photo.CopyToAsync(fileStream);
                }

                News news = new News()
                {
                    PhotoUrl = fileName,
                    Title = creatingNews.Title,
                    Info = creatingNews.Info,
                    AddDate=DateTime.Now,
                };

                _context.News.Add(news);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("News","Dashboard");
        }

        [HttpGet]
        [ActionName("EditNews")]
        public IActionResult EditNewsGet(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            if (id == null)
            {
                return RedirectToAction("Error","Home");
            }

            News selectedNews = _context.News.Find(id);

            if (selectedNews == null)
            {
                return RedirectToAction("Error","Home");
            }

            return View(selectedNews);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("EditNews")]
        public async Task<IActionResult> EditNewsPost(int? id, News selectednews)
        {
            if (id == null)
            {
                return NotFound();
            }

            News newsFromDb = _context.News.Find(id);

            if (newsFromDb == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bütün dəyərləri daxil edin!");
                return View(selectednews);
            }

            if (selectednews.Photo == null)
            {
                ModelState.AddModelError("Photo", "Xəbərin Şəklin Yükləyin");
                return View(selectednews);
            }

            string currentFilePath = Path.Combine(_env.WebRootPath, "img", newsFromDb.PhotoUrl);
            if (System.IO.File.Exists(currentFilePath))
            {
                System.IO.File.Delete(currentFilePath);
            }

            if (selectednews.Photo.ContentType.Contains("image/"))
            {
                string folderPath = Path.Combine(_env.WebRootPath, "img");
                string fileName = Guid.NewGuid().ToString() + "_" + selectednews.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await selectednews.Photo.CopyToAsync(fileStream);
                }

                newsFromDb.PhotoUrl = fileName;
                newsFromDb.Title = selectednews.Title;
                newsFromDb.Info = selectednews.Info;

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("News","Dashboard");
        }



        [HttpGet]
        [ActionName("DeleteNews")]
        public IActionResult DeleteNewsGet(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            if (id == null)
            {
                return RedirectToAction("Error","Home");
            }

            News newsFromDb = _context.News.Find(id);

            if (newsFromDb == null)
            {
                return NotFound();
            }

            return View(newsFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteNews")]
        public async Task<IActionResult> DeleteNewsPost(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error","Home");
            }

            News selectedNewsFromDb = _context.News.Find(id);

            if (selectedNewsFromDb == null)
            {
                return RedirectToAction("Error","Home");
            }

            string currentFilePath = Path.Combine(_env.WebRootPath, "img", selectedNewsFromDb.PhotoUrl);
            if (System.IO.File.Exists(currentFilePath))
            {
                System.IO.File.Delete(currentFilePath);
            }

            _context.News.Remove(selectedNewsFromDb);

            await _context.SaveChangesAsync();

            return RedirectToAction("News","Dashboard");
        }

        public IActionResult Models()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminLogin", "Dashboard");
            }
            return View(_context.Models.OrderBy(m=> m.MarkId));
        }
        public IActionResult CreateModel()
        {
            ViewBag.Categories = _context.Categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateModel(Model creatingModel)
        {

            ViewBag.Categories = _context.Categories;
            if (creatingModel.Name == null)
            {
                ModelState.AddModelError("", "Zəhmət Olmasa Modelin adın daxil edin");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Cities = _context.Cities;
                ViewBag.Marks = _context.Marks;
                ViewBag.Categories = _context.Categories;
                ViewBag.Models = _context.Models;
                ModelState.AddModelError("", "Zəhmət Olmasa Modelin adın daxil edin");
                return View(creatingModel);
            }
            Model newModel = new Model()
            {
                Name =creatingModel.Name,
                MarkId=creatingModel.MarkId,
            };

            await  _context.Models.AddAsync(newModel);

            await _context.SaveChangesAsync();

            return RedirectToAction("Models","Dashboard");
        }


        
        public IActionResult AdminForgetPassword()
        {
            return View();
        }



        
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminForgetPassword(ForgetPasswordVM forgetPassViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət Olmasa emailinizi daxil edin");
                return View(forgetPassViewModel);
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(forgetPassViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu email qeydiyyatdan keçirilməyib.");
                return View(forgetPassViewModel);
            }

            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"], _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("powerElectronics.az@gmail.com", forgetPassViewModel.Email);
            message.IsBodyHtml = true;
            message.Subject = "Hesabın Bərpası";
            message.Body = $"<a href='http://power123elec-001-site1.ctempurl.com/PowerAdmin/Dashboard/AdminChangePassword?userId={user.Id}&passwordResetToken={passwordResetToken}'>Hesabın bərpası</a>";
            await  client.SendMailAsync(message);



            return View();
        }


        public async Task<IActionResult> AdminChangePassword(string userId, string passwordResetToken)
        {
            string replacedPasswordResetToken = passwordResetToken.Replace(" ", "+");

            ViewBag.UserId = userId;
            ViewBag.PasswordResetToken = replacedPasswordResetToken;
            if (passwordResetToken == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return RedirectToAction("Error", "Home");
            }

            ApplicationUser user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return RedirectToAction("Error", "Home");
            }

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminChangePassword(ChangePasswordVM changePasswordViewModel)
        {
            TempData["ForgetPassword"] = true;

            ViewBag.UserId = changePasswordViewModel.UserId;
            ViewBag.PasswordResetToken = changePasswordViewModel.PasswordResetToken;
            ApplicationUser user = await _userManager.FindByIdAsync(changePasswordViewModel.UserId);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət Olmasa Düzgün  dəyərlər daxil edin");
                ViewBag.UserId = changePasswordViewModel.UserId;
                ViewBag.PasswordResetToken = changePasswordViewModel.PasswordResetToken;
                return View(changePasswordViewModel);
            }
            

            IdentityResult result = await _userManager.ResetPasswordAsync(user, changePasswordViewModel.PasswordResetToken, changePasswordViewModel.NewPassword);

            if (!result.Succeeded)
            {
                ViewBag.UserId = changePasswordViewModel.UserId;
                ViewBag.PasswordResetToken = changePasswordViewModel.PasswordResetToken;
                ModelState.AddModelError("", "Daxil etdiyiniz şifrə tələblərə uyğun deyil.");
                return View(changePasswordViewModel);
            }

            await _userManager.UpdateAsync(user);
            TempData["AccountRestored"] = true;
            return RedirectToAction("AdminLogin", "Dashboard");
        }





    }


}
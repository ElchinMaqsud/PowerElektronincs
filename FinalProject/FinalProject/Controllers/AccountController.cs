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

namespace FinalProject.Controllers
{
    

    public class AccountController : Controller
    {
        private readonly FinalProject_Db _context;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public AccountController(FinalProject_Db context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IHostingEnvironment env, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _configuration = configuration;
        }


        
        [ActionName("Register")]
        public IActionResult RegisterGet()
        {
            ViewBag.Operators = _context.Operators.ToList();
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public async Task<IActionResult> RegisterPost(RegisterVM creatingUser)
        {
            creatingUser.RegisterDate = DateTime.Now;
            if (!ModelState.IsValid)
            {
                ViewBag.Operators = _context.Operators.ToList();
                ModelState.AddModelError("", "Zəhmət olmasa məlumatları doğru daxil edin");
                return View(creatingUser);
            }
            Operator operatorFromDb = _context.Operators.FirstOrDefault(o => o.Id == creatingUser.OperatorId);

          
            ApplicationUser user = new ApplicationUser()
            {
                Firstname = creatingUser.FirstName,
                Lastname = creatingUser.LastName,
                RegisterDate = creatingUser.RegisterDate,
                Email = creatingUser.Email,
                UserName = creatingUser.UserName,
                PhoneNumber =  creatingUser.PhoneNumber,
                OperatorId = creatingUser.OperatorId,
               
            };

          


            if (creatingUser.Photo == null)
            {
                user.PhotoUrl = "noImage.png";

            }
            else if (creatingUser.Photo.ContentType.Contains("image/"))
            {
                string folderPath = Path.Combine(_env.WebRootPath, "userImages");
                string fileName = Guid.NewGuid().ToString() + "_" + creatingUser.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);
                user.PhotoUrl = fileName;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await creatingUser.Photo.CopyToAsync(fileStream);
                }
            }


            IdentityResult result = await _userManager.CreateAsync(user, creatingUser.Password);

            if (!result.Succeeded)
            {
                ViewBag.Operators = _context.Operators.ToList();
                ModelState.AddModelError("", "username və ya şifrə düzgün daxil edilməyib");
                return View(creatingUser);
            }

            
                await _userManager.AddToRoleAsync(user, "İstifadəçi");
            

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"], _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("powerElectronics.az@gmail.com", creatingUser.Email);
            message.IsBodyHtml = true;
            message.Subject = "Hesabın təsdiqlənməsi";
            message.Body = $"<a href='http://power123elec-001-site1.ctempurl.com/Account/EmailVerify?id={user.Id}'>Xahiş edirik hesabınızı təsdiqləyəsiniz</a>";
             await client.SendMailAsync(message);
            return RedirectToAction("Login", "Account");

        }




        public async Task<IActionResult> EmailVerify(string id)
        {
            if (id != null)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);

                

                if (user != null)
                {
                    user.EmailConfirmed = true;
                    TempData["Email Təsdiqləndi"] = true;
                    
                 

                    await _context.SaveChangesAsync();

                }
            }
            TempData["Verify"] = true;
            return RedirectToAction("Login", "Account");
        }




        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginvm)
        {


            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir!");
                return View(loginvm);
            }

            ApplicationUser user = await _userManager.FindByNameAsync(loginvm.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
                return View(loginvm);
            }

            if (user.EmailConfirmed == false)
            {
                TempData["EmailConfirm"] = true;
                return RedirectToAction("Login", "Account");
            }


            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginvm.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username və ya şifrə səhvdir");
                return View(loginvm);
            }
            

            await _signInManager.SignInAsync(user, true);


            return RedirectToAction("Index", "Home");


        }



        public IActionResult LogOut()
        {
            if (User.Identity.IsAuthenticated)
            {
                _signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }




        [ActionName("ForgetPassword")]
        public IActionResult ForgetPasswordGet()
        {
            return View();
        }



        [ActionName("ForgetPassword")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPasswordPost(ForgetPasswordVM forgetPassViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Emailinizi daxil edin");
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
            message.Body = $"<a href='http://power123elec-001-site1.ctempurl.com/Account/ChangePassword?userId={user.Id}&passwordResetToken={passwordResetToken}'>Hesabın bərpası</a>";
             await client.SendMailAsync(message);

            

            return View();
        }





        public async Task<IActionResult> ChangePassword(string userId, string passwordResetToken)
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
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePasswordViewModel)
        {
            TempData["ForgetPassword"] = true;

            ViewBag.UserId = changePasswordViewModel.UserId;
            ViewBag.PasswordResetToken = changePasswordViewModel.PasswordResetToken;
            ApplicationUser user = await _userManager.FindByIdAsync(changePasswordViewModel.UserId);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa düzgün dəyərlər daxil edin!");
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
            return RedirectToAction("Login", "Account");
        }





        [Authorize(Roles = "İstifadəçi")]
        public async Task<IActionResult> UserProfile()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserProfileVM userProfileVM = new UserProfileVM()
            {
                LoggedUser = user,
                Announcements = _context.Announcements.Where(a => a.ApplicationUserId == user.Id).Where(a => a.IsConfirmed == true).OrderByDescending(ads => ads.AddDate).ToList()
            };
            return View(userProfileVM);
        }





        [Authorize(Roles = "İstifadəçi")]
        public async Task<IActionResult> EditProfile()
        {
            ViewBag.Operators = _context.Operators;

            ApplicationUser loggedUser = await _userManager.FindByNameAsync(User.Identity.Name);

            UpdateProfileVM updateProfileVM = new UpdateProfileVM()
            {
                applicationUser = loggedUser,
                
            };
            if (updateProfileVM == null) return RedirectToAction("Error","Home");

            return View(updateProfileVM);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(UpdateProfileVM updateProfileVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa mobil operatorunuzu Daxil Edin");
                ViewBag.Operators = _context.Operators;
                return View(updateProfileVM);
            }
            ApplicationUser applicationUser =  await _userManager.FindByNameAsync(User.Identity.Name);
            applicationUser.Firstname = updateProfileVM.applicationUser.Firstname;
            applicationUser.Lastname = updateProfileVM.applicationUser.Lastname;
            applicationUser.UserName = updateProfileVM.applicationUser.UserName;
            applicationUser.OperatorId = updateProfileVM.OperatorId;
            applicationUser.PhoneNumber = updateProfileVM.applicationUser.PhoneNumber;

            if (updateProfileVM.applicationUser.Email != applicationUser.Email)
            {
                applicationUser.Email = updateProfileVM.applicationUser.Email;
                applicationUser.EmailConfirmed = false;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"], _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
                MailMessage message = new MailMessage("powerElectronics.az@gmail.com", updateProfileVM.applicationUser.Email);
                message.IsBodyHtml = true;
                message.Subject = "Hesabın təsdiqlənməsi";
                message.Body = $"<a href='http://power123elec-001-site1.ctempurl.com/Account/EmailVerify?id={updateProfileVM.applicationUser.Id}'>Xahiş edirik hesabınızı təsdiqləyəsiniz</a>";
                await client.SendMailAsync(message);
            }
            if (updateProfileVM.Photo == null)
            {
                applicationUser.PhotoUrl = "noImage.png";

            }
            else if (updateProfileVM.Photo.ContentType.Contains("image/"))
            {
                string folderPath = Path.Combine(_env.WebRootPath, "userImages");
                string fileName = Guid.NewGuid().ToString() + "_" + updateProfileVM.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);
                applicationUser.PhotoUrl = fileName;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await updateProfileVM.Photo.CopyToAsync(fileStream);
                }
            }
            if (updateProfileVM.NewPassword != null)
            {
                await _userManager.ChangePasswordAsync(applicationUser, updateProfileVM.СurrentPassword, updateProfileVM.NewPassword);
            }
         
            _context.SaveChanges();
            return RedirectToAction("UserProfile", "Account");

            
        }





        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteUserPhoto()
        {
            ApplicationUser loggedUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!string.IsNullOrEmpty(loggedUser.PhotoUrl))
            {
                var imagePath = Path.Combine(_env.WebRootPath, "userImages", loggedUser.PhotoUrl);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                    loggedUser.PhotoUrl = null;
                    await _context.SaveChangesAsync();
                    return Json(new { status = 200 });
                }
            }
         
            return Json(new { status = 404, text = "sekil yoxdu" });
        }



        [Authorize(Roles = "İstifadəçi")]
        public IActionResult CreateAds()
        {
            ViewBag.Cities = _context.Cities;
            ViewBag.Categories = _context.Categories;
            ViewBag.Marks = _context.Marks;
            ViewBag.Models = _context.Models;
            ViewBag.Operators = _context.Operators;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAds(adsVM adsCreateVM)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            adsCreateVM.Announcement.ApplicationUserId = user.Id;

            ViewBag.Cities = _context.Cities;
            ViewBag.Marks = _context.Marks;
            ViewBag.Categories = _context.Categories;
            ViewBag.Models = _context.Models;

            if (!ModelState.IsValid)
            {
                ViewBag.Cities = _context.Cities;
                ViewBag.Marks = _context.Marks;
                ViewBag.Categories = _context.Categories;
                ViewBag.Models = _context.Models;
                ModelState.AddModelError("", "Zəhmət Olmasa Düzgün məlumatlar daxil edin");
                return View(adsCreateVM);
            }

            if (adsCreateVM.Announcement.Photo == null)
            {
                ViewBag.Cities = _context.Cities;
                ViewBag.Marks = _context.Marks;
                ViewBag.Categories = _context.Categories;
                ViewBag.Models = _context.Models;
                ModelState.AddModelError("", "Zəhmət Olmasa  əsas şəkil daxil Edin");
                return View(adsCreateVM);
            }

            

            if (adsCreateVM.Announcement.AnsAllImages != null)
            {
                if (adsCreateVM.Announcement.AnsAllImages.Count > 4)
                {
                    ViewBag.Categories = _context.Categories;
                    ViewBag.Marks = _context.Marks;
                    ViewBag.Models = _context.Models;
                    ViewBag.Cities = _context.Cities;
                    ModelState.AddModelError("", "Maksimum 4 şekil daxil ede bilersiniz");
                    return View(adsCreateVM);
                }
                foreach (var adsImage in adsCreateVM.Announcement.AnsAllImages)
                {
                    if (adsImage == null)
                    {
                        ViewBag.Cities = _context.Cities;
                        ViewBag.Marks = _context.Marks;
                        ViewBag.Categories = _context.Categories;
                        ViewBag.Models = _context.Models;
                        ModelState.AddModelError("", "Zəhmət olmasa elanın şəkillərin daxil edin");
                        return View(adsCreateVM);
                    }
                }
            }
            

        

            

            Announcement creatingAds = new Announcement()
            {
                Name = adsCreateVM.Announcement.Name,
                Price = adsCreateVM.Announcement.Price,
                AddDate = DateTime.Now,
                Info = adsCreateVM.Announcement.Info,
                ModelId = adsCreateVM.Announcement.ModelId,
                CityId = adsCreateVM.Announcement.CityId,
                ApplicationUserId = user.Id,
            };
            if (adsCreateVM.Announcement.Photo.Length >= 2 * 1024 * 1024)
            {
                ViewBag.Cities = _context.Cities;
                ViewBag.Marks = _context.Marks;
                ViewBag.Categories = _context.Categories;
                ViewBag.Models = _context.Models;
                ModelState.AddModelError("", "Sekilin Olcusu 2 meqabaytdan az olmalidir");
                return View(adsCreateVM);
            }
            if (adsCreateVM.Announcement.Photo.ContentType.Contains("image/"))
            {
                
                string folderPath = Path.Combine(_env.WebRootPath, "img");
                string fileName = Guid.NewGuid().ToString() + "_" + adsCreateVM.Announcement.Photo.FileName;
                string filePath = Path.Combine(folderPath, fileName);
                creatingAds.PhotoUrl = fileName;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await adsCreateVM.Announcement.Photo.CopyToAsync(fileStream);
                }
            }

            await _context.Announcements.AddAsync(creatingAds);
            foreach (var adsImage in adsCreateVM.Announcement.AnsAllImages)
            {
                if (adsImage.Length >= 2 * 1024 * 1024)
                {
                    ViewBag.Cities = _context.Cities;
                    ViewBag.Marks = _context.Marks;
                    ViewBag.Categories = _context.Categories;
                    ViewBag.Models = _context.Models;
                    ModelState.AddModelError("", "Sekilin Olcusu 2 meqabaytdan az olmalidir");
                    return View(adsCreateVM);
                }
                if (adsImage.ContentType.Contains("image/"))
                {
                    string folderPathAll = Path.Combine(_env.WebRootPath, "img");
                    string fileNameAll = Guid.NewGuid().ToString() + "_" + adsImage.FileName;
                    string filePathALL = Path.Combine(folderPathAll, fileNameAll);

                    using (FileStream fileStreama = new FileStream(filePathALL, FileMode.Create))
                    {
                        await adsImage.CopyToAsync(fileStreama);
                    }
                    AnsImages img = new AnsImages
                    {
                        AnnouncementId = creatingAds.Id,
                        AdsPhotoUrl= fileNameAll,
                    };
                    _context.AnsImages.Add(img);

                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }





        [Authorize(Roles = "İstifadəçi")]
        [ActionName("EditAds")]
        public IActionResult EditAdsGet(int? id)
        {
            if (id == null) return RedirectToAction("Error","Home");
            ViewBag.Categories = _context.Categories;
            ViewBag.Marks = _context.Marks;
            ViewBag.Models = _context.Models;
            ViewBag.Cities = _context.Cities;
            Announcement selectedAds = _context.Announcements.Find(id);
            return View(selectedAds);
        }

        [ActionName("EditAds")]
        [HttpPost]
        public async Task<IActionResult> EditAdsPost(Announcement selectedAds)
        {
          
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories;
                ViewBag.Marks = _context.Marks;
                ViewBag.Models = _context.Models;
                ViewBag.Cities = _context.Cities;
                ModelState.AddModelError("","Xaiş olunur duzgun deyerler daxil edesiniz");
                return View(selectedAds);
            }

            Announcement adsFromDb = await _context.Announcements.FindAsync(selectedAds.Id);

            ApplicationUser loggedUser = await  _userManager.FindByNameAsync(User.Identity.Name);

            if (loggedUser == null || adsFromDb.ApplicationUserId != loggedUser.Id)
            {
                ViewBag.Categories = _context.Categories;
                ViewBag.Marks = _context.Marks;
                ViewBag.Models = _context.Models;
                ViewBag.Cities = _context.Cities;
                ModelState.AddModelError("", "siz active istifadeci deyilsiniz");
                return View(selectedAds);
            }


            if (adsFromDb == null) return RedirectToAction("Error","Home");
            if(selectedAds.Photo != null)
            {
                if (selectedAds.Photo.ContentType.Contains("image/"))
                {
                    string currentFilePath = Path.Combine(_env.WebRootPath, "image", adsFromDb.PhotoUrl);
                    if (System.IO.File.Exists(currentFilePath))
                    {
                        System.IO.File.Delete(currentFilePath);
                    }

                    string folderPath = Path.Combine(_env.WebRootPath, "img");
                    string fileName = Guid.NewGuid().ToString() + "_" + selectedAds.Photo.FileName;
                    string filePath = Path.Combine(folderPath, fileName);
                    adsFromDb.PhotoUrl = fileName;

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await selectedAds.Photo.CopyToAsync(fileStream);
                    }


                }
            }
            

           
            if (selectedAds.AnsAllImages != null)
            {
                int dbImageCount = adsFromDb.AnsImages != null ? adsFromDb.AnsImages.Count : 0;
                if ( (dbImageCount + selectedAds.AnsAllImages.Count) > 4)
                {
                    ViewBag.Categories = _context.Categories;
                    ViewBag.Marks = _context.Marks;
                    ViewBag.Models = _context.Models;
                    ViewBag.Cities = _context.Cities;
                    ModelState.AddModelError("", "Maksimum 4 şekil daxil ede bilersiniz");
                    selectedAds.AnsImages = adsFromDb.AnsImages;
                    return View(selectedAds);
                }
                foreach (var adsImage in selectedAds.AnsAllImages)
                {

                    if (adsImage == null)
                    {
                        ViewBag.Categories = _context.Categories;
                        ViewBag.Marks = _context.Marks;
                        ViewBag.Models = _context.Models;
                        ViewBag.Cities = _context.Cities;
                        ModelState.AddModelError("", "Zəhmət olmasa şekilleri daxil edin");

                    }
                    if (adsImage.ContentType.Contains("image/"))
                    {
                        string folderPathAll = Path.Combine(_env.WebRootPath, "img");
                        string fileNameAll = Guid.NewGuid().ToString() + "_" + adsImage.FileName;
                        string filePathALL = Path.Combine(folderPathAll, fileNameAll);

                        using (FileStream fileStream = new FileStream(filePathALL, FileMode.Create))
                        {
                            await adsImage.CopyToAsync(fileStream);
                        }

                        AnsImages img = new AnsImages()
                        {
                            AnnouncementId = adsFromDb.Id,
                            AdsPhotoUrl = fileNameAll
                        };
                        _context.AnsImages.Add(img);
                    }
                }

            }
            adsFromDb.Name = selectedAds.Name;
            adsFromDb.Price = selectedAds.Price;
            adsFromDb.Info = selectedAds.Info;
            adsFromDb.ModelId = selectedAds.ModelId;
            adsFromDb.CityId = selectedAds.CityId;
            adsFromDb.ApplicationUserId = loggedUser.Id;
            _context.SaveChanges();

            return RedirectToAction("UserProfile","Account");
        }

        [Authorize(Roles = "İstifadəçi")]
        [ActionName("DeleteAds")]
        public  IActionResult DeleteAdsGet(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error","Home");
            }

            Announcement adsFromDb = _context.Announcements.Find(id);

            if (adsFromDb == null)
            {
                return RedirectToAction("Error","Home");
            }

            return View(adsFromDb);
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteAds")]
        public async Task<IActionResult> DeleteAdsPost(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error","Home");
            }

            Announcement selectedAdsFromDb = _context.Announcements.Find(id);

            if (selectedAdsFromDb == null)
            {
                return RedirectToAction("Error", "Home");
            }

            string currentFilePath = Path.Combine(_env.WebRootPath, "img", selectedAdsFromDb.PhotoUrl);
            if (System.IO.File.Exists(currentFilePath))
            {
                System.IO.File.Delete(currentFilePath);
            }
            foreach (var img in selectedAdsFromDb.AnsImages)
            {
                string currentAdsImgFilePath = Path.Combine(_env.WebRootPath, "img", img.AdsPhotoUrl);
                if (System.IO.File.Exists(currentAdsImgFilePath))
                {
                    System.IO.File.Delete(currentAdsImgFilePath);
                }
            }

            _context.Announcements.Remove(selectedAdsFromDb);

            await _context.SaveChangesAsync();

            return RedirectToAction("UserProfile","Account");
        }
       
    }
    
}
     



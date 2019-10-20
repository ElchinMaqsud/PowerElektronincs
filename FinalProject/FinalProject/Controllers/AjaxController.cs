    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Db;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AjaxController : Controller
    {
        private readonly FinalProject_Db _context;
        public AjaxController(FinalProject_Db context)
        {
            _context = context;
        }
        public IActionResult SelectMarks(int? Id)
        {

            return PartialView("_SelectMarksPartialView", _context.Marks.Where(m => m.CategoryId == Id));
        }
        public IActionResult SelectModels(int? Id)
        {
            return PartialView("_SelectModelsPartialView", _context.Models.Where(mo => mo.MarkId == Id));
        }
        public async Task<IActionResult> DeleteAdsImage(int? ImageId)
        {


            AnsImages deletingImage = _context.AnsImages.FirstOrDefault(i => i.Id == ImageId);
            if (deletingImage.Id != ImageId)
            {
                return RedirectToAction("Error", "Home");
            }


            _context.AnsImages.Remove(deletingImage);
            await _context.SaveChangesAsync();
            return RedirectToAction("EditAds", "Account");



        }

        public IActionResult LoadMoreAds(int Skipcount)
        {
            HomeVM homeVM = new HomeVM
            {

                Announcements = _context.Announcements.Skip(Skipcount).Take(6).ToList()
            };

            return PartialView("loadMoreAdvertisements", homeVM);
        }
        public IActionResult SearchAds(int? categoryId, int? markId, int? modelId, int? price)
        {

            if (categoryId == null && markId == null && modelId == null)
            {
                HomeVM homeVM = new HomeVM
                {
                    Announcements = _context.Announcements.Where(a => a.Price <= Convert.ToInt32(price)).ToList()
                };

                return PartialView("SearchAdsPartialView", homeVM);
            }

            if (price == null && markId == null && modelId == null)
            {
                HomeVM homeVM = new HomeVM
                {
                    Announcements = _context.Announcements.Where(a => a.Model.Mark.CategoryId == categoryId).ToList()
                };

                return PartialView("SearchAdsPartialView", homeVM);
            }

            if (price == null && modelId == null)
            {
                HomeVM homeVM = new HomeVM
                {
                    Announcements = _context.Announcements.Where(a => a.Model.Mark.CategoryId == categoryId && a.Model.MarkId == markId).ToList()
                };

                return PartialView("SearchAdsPartialView", homeVM);
            }

            if(markId==null && modelId == null)
            {
                HomeVM homeVM = new HomeVM()
                {
                    Announcements = _context.Announcements.Where(a => a.Model.Mark.CategoryId == categoryId &&  a.Price <= Convert.ToInt32(price)).ToList()
                };
                return PartialView("SearchAdsPartialView", homeVM);
            }

            if (price == null)
            {
                HomeVM homeVM = new HomeVM()
                {
                    Announcements = _context.Announcements.Where(a => a.Model.Mark.CategoryId == categoryId && a.Model.Id == modelId && a.Model.MarkId == markId).ToList()
                };
                return PartialView("SearchAdsPartialView", homeVM);
            }


            HomeVM homeVM1 = new HomeVM()
            {
                Announcements = _context.Announcements.ToList()
            };

            return PartialView("SearchAdsPartialView", homeVM1);

        }
        
        public IActionResult LoadMoreInfo(int skipCount)
        {
            IEnumerable<News> news = _context.News.Skip(skipCount).Take(6);
            return PartialView("LoadMoreNewsPartialView", news);
        }

    }

}

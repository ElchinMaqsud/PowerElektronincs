using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Db;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.PowerAdmin.Controllers
{
    [Area("PowerAdmin")]
    public class AdminAjaxController : Controller
    {
        private readonly FinalProject_Db _context;
        public AdminAjaxController(FinalProject_Db context)
        {
            _context = context;
        }
        public IActionResult SelectMarks(int? Id)
        {

            return PartialView("_SelectMarksPartialView", _context.Marks.Where(m => m.CategoryId == Id));
        }
    }
}
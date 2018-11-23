using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YX.Core.Database;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YX.Web.Controllers
{
    public class OpenDataController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            OpenDataDbContext db = new OpenDataDbContext();
            List<YX.Core.Models.OpenData> models = db.OpenData.ToList();

            return View(models);
        }
    }
}

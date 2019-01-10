using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YX.Core.Database;
using YX.Core.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YX.Web.Controllers
{
    public class OpenDataTypeController : Controller
    {
        // GET: /<controller>/
        public OpenDataTypeController()
        {
            DbContext = new OpenDataDbContext();
        }

        public OpenDataDbContext DbContext { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Import()
        //{

        //    var groupings = DbContext.OpenData
        //        .GroupBy(x => x.服務分類, y => y)
        //        .ToList();

        //    groupings.ForEach(group =>
        //    {
        //        var key = group.Key;
        //        OpenDataType type = new OpenDataType
        //        {
        //            Name = key
        //        };
        //        DbContext.OpenDataType.Add(type);
        //    });
        //    DbContext.SaveChanges();
        //    return Content("Done");
        //}
    }
}

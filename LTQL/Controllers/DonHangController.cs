using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class DonHangController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: DonHang
        public ActionResult Index()
        {
            return View(db.DonHangs.ToList());
        }
    }
}
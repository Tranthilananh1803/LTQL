using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;
namespace LTQL.Controllers
{
    public class KhachHangController : Controller
    {
        //khai bao doi tuong ket noi toi database
        LTQLDbContext db = new LTQLDbContext();
        // GET: KhachHang
        public ActionResult Index()
        {
            //lay toan bo du lieu trong bang khach hang
            //tra ve list roi hien thi len view
            return View(db.KhachHangs.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thực_Hành_Css.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult vd1()
        {
            ViewBag.Message = "Highligh văn bản.";

            return View();
        }
        public ActionResult vd2()
        {
            ViewBag.Message = "Định dạng cho link.";

            return View();
        }
        public ActionResult vd3()
        {
            ViewBag.Message = "Định dạng văn bản bị gạch ngang.";

            return View();
        }
        public ActionResult vd4()
        {
            ViewBag.Message = "Định dạng khoảng thụt vào đàu lòng cho văn bản.";

            return View();
        }
        public ActionResult vd5()
        {
            ViewBag.Message = "Tạo tooltip cho các từ viết tắt trong văn bản.";

            return View();
        }
        public ActionResult vd6()
        {
            ViewBag.Message = "Drop Cap.";

            return View();
        }
        public ActionResult vd01()
        {
            ViewBag.Message = "ĐỊNH DẠNG VĂN BẢN.";

            return View();
        }
        public ActionResult vd02()
        {
            ViewBag.Message = "ĐỊNH DẠNG VĂN BẢN.";

            return View();
        }
        public ActionResult Table1()
        {
            ViewBag.Message = "Tạo các mẫu table.";

            return View();
        }
        public ActionResult Table2()
        {
            ViewBag.Message = "Tạo các mẫu table.";

            return View();
        }
        public ActionResult Table3()
        {
            ViewBag.Message = "Tạo các mẫu table.";

            return View();
        }
        public ActionResult Navigator01()
        {
            ViewBag.Message = "TẠO THANH NAVIGATOR.";

            return View();
        }
        public ActionResult Web01()
        {
            ViewBag.Message = "TẠO THANH NAVIGATOR.";

            return View();
        }
    }
}
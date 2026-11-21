using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranCongVinh_241230893_de2023.Models;

namespace TranCongVinh_241230893_de2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _db;
        public HomeController(QlhangHoaContext db) { _db = db; }

        public IActionResult Index()
        {
            ViewBag.Tieu = "Trần Công Vinh";
            return View(_db.HangHoas.Where(h => h.Gia >= 100).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

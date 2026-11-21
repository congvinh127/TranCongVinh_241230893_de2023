using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TranCongVinh_241230893_de2023.Models;

namespace TranCongVinh_241230893_de2023.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly QlhangHoaContext _db;
        public HangHoaController(QlhangHoaContext db) { _db = db; }

        public IActionResult ByLoai(int id)
        {
            ViewBag.Tieu = "New Products";
            var ds = _db.HangHoas.Where(h => h.MaLoai == id).ToList();
            return PartialView("TranCongVinh_MainContent", ds);
        }

        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_db.LoaiHangs, "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        public IActionResult Create(HangHoa model)
        {
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                _db.HangHoas.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaLoai = new SelectList(_db.LoaiHangs, "MaLoai", "TenLoai", model.MaLoai);
            return View(model);
        }
    }
}

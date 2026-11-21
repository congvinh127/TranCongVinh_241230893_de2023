using Microsoft.AspNetCore.Mvc;
using TranCongVinh_241230893_de2023.Models;
namespace TranCongVinh_241230893_de2023.ViewComponents
{
    public class LoaiHangMenuViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _db;
        public LoaiHangMenuViewComponent(QlhangHoaContext db) { _db = db;  }
        public IViewComponentResult Invoke() => View(_db.LoaiHangs.ToList());
    }
}

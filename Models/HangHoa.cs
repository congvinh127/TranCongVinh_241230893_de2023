using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TranCongVinh_241230893_de2023.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }
    [Required(ErrorMessage = "Nhâp tên hàng")]
    public string TenHang { get; set; }
    [Range(100,5000,ErrorMessage = " giá phải là số và nằm trong giới hạn 100 đến 5000")]
    [Required(ErrorMessage = "Nhâp giá")]
    public decimal? Gia { get; set; }
    [AnhExtension(ErrorMessage = "Tên ảnh phải có đuôi .jpg, .png, .gif hoặc .tiff")]
    public string Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; }
}

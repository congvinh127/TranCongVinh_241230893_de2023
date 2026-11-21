using System.ComponentModel.DataAnnotations;
namespace TranCongVinh_241230893_de2023.Models
{
    public class AnhExtensionAttribute : ValidationAttribute
    {
        private static readonly string[] ok = { ".jpg", ".png", ".gif", ".tiff" };
        public override bool IsValid(object value)
        {
            var s = value as string;
            if (string.IsNullOrWhiteSpace(s)) return false;
            return ok.Contains(Path.GetExtension(s).ToLower());
        }
    }
}

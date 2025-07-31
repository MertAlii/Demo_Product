using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}

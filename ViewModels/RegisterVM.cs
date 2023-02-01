using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Ecommerce.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunlu!")]
        public string Username { get; set; }



        [Required(ErrorMessage = "Email  zorunlu!")]
        [EmailAddress(ErrorMessage = "Email formatında bir değer girin!")]
        public string Email { get; set; }




        [Required(ErrorMessage = "Şifre zorunlu!")]
        [MinLength(6, ErrorMessage = "(Şifreniz en az 6 karakterli olmalıdır!)")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre (Tekrar) zorunlu!")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
    }
}

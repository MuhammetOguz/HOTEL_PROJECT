using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad girmeniz gerekiyor")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad girmeniz gerekiyor")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı girmeniz gerekiyor")]

        public string Username { get; set; }

        public string City { get; set; }

        [Required(ErrorMessage = "Mail girmeniz gerekiyor")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre girmeniz gerekiyor")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Tekrar şifreyi girmeniz gerekiyor")]
        [Compare("Password",ErrorMessage="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}

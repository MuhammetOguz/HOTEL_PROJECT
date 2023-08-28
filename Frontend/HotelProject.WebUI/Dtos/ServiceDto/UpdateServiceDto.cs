using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter giriniz")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(200, ErrorMessage = "Lütfen en fazla 200 karakter giriniz")]
        public string Description { get; set; }
    }
}

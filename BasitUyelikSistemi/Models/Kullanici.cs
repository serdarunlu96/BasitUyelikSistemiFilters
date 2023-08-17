using System.ComponentModel.DataAnnotations;

namespace BasitUyelikSistemi.Models
{
    public class Kullanici
    {
        [Required(ErrorMessage = "Kullanici adi zorunlu!")]
        public string KullaniciAdi { get; set; } = null!;

        [Required(ErrorMessage = "Parola zorunlu!")]
        [DataType(DataType.Password)]
        public string Parola { get; set; } = null!;
    }
}

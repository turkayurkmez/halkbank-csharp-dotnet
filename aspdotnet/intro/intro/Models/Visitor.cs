

using System.ComponentModel.DataAnnotations;

namespace intro.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen isminizi giriniz")]
        [MinLength(2, ErrorMessage = "En az iki karakter giriniz")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "E-posta formatı hatalı")]
        [Required(ErrorMessage = "Lütfen epostanızı giriniz")]
        public string Email { get; set; }
        public bool? IsComing { get; set; }
    }
}

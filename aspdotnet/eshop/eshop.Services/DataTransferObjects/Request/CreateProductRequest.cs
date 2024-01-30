using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services.DataTransferObjects.Request
{
    public class CreateProductRequest
    {
        [Required(ErrorMessage = "Lütfen ürün adını unutmayınız")]
        [MinLength(2, ErrorMessage = "Ürün adı en az 2 karakter olmalı")]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter girilebilir")]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Required(ErrorMessage = "Ürünb fiyatı zorunludur!")]
        public decimal Price { get; set; }

        public int? Stock { get; set; }
        public string? ImageUrl { get; set; }

        public int? CategoryId { get; set; }
    }
}

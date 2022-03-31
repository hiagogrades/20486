using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http; //ToDo: 1- Adicionar a biblicoteca HTTP
using System.ComponentModel.DataAnnotations; //ToDo: 2 - trabalhando com data Annotation

namespace ButterfliesShop.Models
{
    public class Butterfly
    {
        //ToDo: 2 - Adicionando os métodos
        public int Id { get; set; }

        [Display(Name = "Common Name:")]
        public string CommonName { get; set; }

        [Display(Name = "Butterfly Family:")]
        public Family? ButterflyFamily { get; set; }

        [Display(Name = "Butterfly Quantity:")]
        public int? Quantity {get; set; }

        [Display(Name = "Characteristics:")]
        public string Characteristics { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Updated on:")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yy}")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Butterflies Picture:")]
        public IFormFile PhotoAvatar { get; set; }
        public string ImageName { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
    }
}

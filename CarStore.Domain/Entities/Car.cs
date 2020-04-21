using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarStore.Domain.Entities
{
    public class Car
    {
        [HiddenInput(DisplayValue =false)]
        public int CarId { get; set; }

        [Display(Name="Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название машины")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание для машины")]
        public string Description { get; set; }

        [Display(Name ="Категория")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию для машины")]
        public string Category { get; set; }

        [Display(Name ="Цена (грн)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение для цены")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}

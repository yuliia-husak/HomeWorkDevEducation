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
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Описание")]
        public string Description { get; set; }

        [Display(Name ="Категория")]
        public string Category { get; set; }

        [Display(Name ="Цена (руб)")]
        public decimal Price { get; set; }
    }
}

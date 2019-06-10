
namespace Shop.Web.Data.Entities
{

    using System;
using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2)", ApplyFormatInEditMode = false)] //moneda de 2decimales = false
        public decimal Price { get; set; }

        [Display(Name ="Image")] //display es para que lo muestre solo como image no con ImageUrl
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is availabe?")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2)", ApplyFormatInEditMode = false)] //Numerico de 2 decimales = false
        public double Stock { get; set; }

    }
}

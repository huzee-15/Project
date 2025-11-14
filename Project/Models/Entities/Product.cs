using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace Project.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }   

        [Required, Range(1,1000)]
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
    }
}

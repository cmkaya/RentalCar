using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity.Concrete;

public class Car : IEntity
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int BrandId { get; set; }
    [Required]
    public string ModelName { get; set; }
    [RegularExpression(@"\d{1,4}$", ErrorMessage = "Year should be numeric and up to four digits.")]    
    public string ModelYear { get; set; }
    [Precision(7, 2)]
    public decimal DailyPrice { get; set; }

    public Color Color { get; set; }
    public Brand Brand { get; set; }
    public ICollection<Rental> Rentals { get; set; }
}
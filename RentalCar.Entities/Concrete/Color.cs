using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entity.Concrete;

public class Color : IEntity
{
    public int Id { get; set; }
    [Required]
    [MaxLength(15, ErrorMessage = "The color should be up to 15 characters.")]
    public string Name { get; set; }

    public ICollection<Car> Cars { get; set; }
}
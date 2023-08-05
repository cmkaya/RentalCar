using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entity.Concrete;

public class Brand : IEntity
{
    public int Id { get; set; }
    [Required]
    [MaxLength(15, ErrorMessage = "The brand should be up to 15 characters.")]
    public string Name { get; set; }

    public ICollection<Car> Cars { get; set; }
}
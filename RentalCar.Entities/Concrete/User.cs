using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entity.Concrete;

public class User : IEntity
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    [MaxLength(30)]
    public string Email { get; set; }
    [Required]
    [MaxLength(12, ErrorMessage = "The password should be up to 12 characters.")]
    public string Password { get; set; }
    public Customer Customer { get; set; }
}
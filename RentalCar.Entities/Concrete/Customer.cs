using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entity.Concrete;

public class Customer : IEntity
{
    [Key, ForeignKey("UserId")]
    public int UserId { get; set; }
    [MaxLength(50)]
    public string CompanyName { get; set; }
    
    public User User { get; set; }
    public ICollection<Rental> Rentals { get; set; }
}
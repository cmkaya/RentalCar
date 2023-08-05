using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entity.Concrete;

public class Customer : IEntity
{
    public int UserId { get; set; }
    [MaxLength(50)]
    public string CompanyName { get; set; }
    public User User { get; set; }
}
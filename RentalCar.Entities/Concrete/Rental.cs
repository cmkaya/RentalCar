using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entity.Concrete;

public class Rental : IEntity
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    [Column(TypeName = "date")]
    public DateTime RentDate { get; set; }
    [Column(TypeName = "date")]
    public DateTime? ReturnDate { get; set; }

    public Car Car { get; set; }
    public Customer Customer { get; set; }
}
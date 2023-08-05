using Core.Dto;

namespace Entity.DTOs;

public class CarDetailsDto : IDto
{
    public string ModelName { get; set; }
    public string BrandName { get; set; }
    public string ColorName { get; set; }
    public decimal DailyPrice { get; set; }
}
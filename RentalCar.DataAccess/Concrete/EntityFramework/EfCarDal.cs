using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Data;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, ApplicationDbContext>, ICarDal
{
    public List<CarDetailsDto> GetCarDetails()
    {
        using var context = new ApplicationDbContext();
        var result = from c in context.Cars
            join b in context.Brands on c.BrandId equals b.Id
            join co in context.Colors on c.ColorId equals co.Id
            select new CarDetailsDto
            {
                ModelName = c.ModelName,
                BrandName = b.Name,
                ColorName = co.Name,
                DailyPrice = c.DailyPrice
            };

        return result.ToList();
    }
}
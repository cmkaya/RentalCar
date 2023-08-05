using Core.Utilities.Results;
using Entity.Concrete;

namespace RentalCar.Business.Abstract;

public interface IBrandService
{
    IDataResult<List<Brand>> GetAllBrands();
    IDataResult<Brand> GetBrandsById(int brandId);
    IResult Add(Brand brand);
    IResult Update(Brand brand);
    IResult Delete(Brand brand);
}
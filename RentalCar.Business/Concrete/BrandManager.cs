using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Abstract;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Concrete;

public class BrandManager : IBrandService
{
    private IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    // Retrieve all the brands
    public IDataResult<List<Brand>> GetAllBrands()
    {
        var brandsToGet = _brandDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<Brand>>(Messages.ListedAllBrands, brandsToGet);
    }

    // Find a brand based on `carId`
    public IDataResult<Brand> GetBrandsById(int brandId)
    {
        var brandToGet = _brandDal.GetFromDatabase(b => b.Id == brandId);
        return new SuccessDataResult<Brand>(Messages.FindedBrand, brandToGet);
    }

    // Add a car object
    public IResult Add(Brand brand)
    {
        _brandDal.AddToDatabase(brand);
        return new SuccessResult(Messages.BrandAdded);
    }

    // Update a brand
    public IResult Update(Brand brand)
    {
        _brandDal.UpdateInDatabase(brand);
        return new SuccessResult(Messages.BrandUpdated);
    }

    // Delete a brand 
    public IResult Delete(Brand brand)
    {
        _brandDal.DeleteFromDatabase(brand);
        return new SuccessResult(Messages.BrandDeleted);
    }
}
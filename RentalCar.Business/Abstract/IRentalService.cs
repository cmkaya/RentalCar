using Core.Utilities.Results;
using Entity.Concrete;

namespace RentalCar.Business.Abstract;

public interface IRentalService
{
    IDataResult<List<Rental>> GetAllRentals();
    IDataResult<Rental> GetRentalById(int rentalId);
    IResult Add(Rental rental);
    IResult Update(Rental rental);
    IResult Delete(Rental rental);
}
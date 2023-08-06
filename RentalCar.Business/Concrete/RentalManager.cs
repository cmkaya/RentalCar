using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Abstract;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Concrete;

public class RentalManager : IRentalService
{
    private IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }

    public IDataResult<List<Rental>> GetAllRentals()
    {
        var rentalsToGet = _rentalDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<Rental>>(Messages.ListedAllRentals, rentalsToGet);
    }

    public IDataResult<Rental> GetRentalById(int rentalId)
    {
        var rentalToGet = _rentalDal.GetFromDatabase(r => r.Id == rentalId);
        return new SuccessDataResult<Rental>(Messages.RetrievedRental, rentalToGet);
    }

    public IResult Add(Rental rental)
    {
        _rentalDal.AddToDatabase(rental);
        return new SuccessResult(Messages.RentalAdded);
    }

    public IResult Update(Rental rental)
    {
        _rentalDal.UpdateInDatabase(rental);
        return new SuccessResult(Messages.RentalUpdated);
    }

    public IResult Delete(Rental rental)
    {
        _rentalDal.DeleteFromDatabase(rental);
        return new SuccessResult(Messages.RentalDeleted);
    }
}
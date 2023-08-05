using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Abstract;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Concrete;

public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    
    // Retrieve all cars
    public IDataResult<List<Car>> GetAllCars()
    {
        // Preventing users from accessing the list of cars
        if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Sunday && DateTime.Now.Hour == 22)
        {
            return new ErrorDataResult<List<Car>>(Messages.Maintenance);
        }
        var carsToGet = _carDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<Car>>(carsToGet);
    }

    // Retrieve cars based on daily price range
    public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
    {
        var carsToGet = _carDal.GetAllFromDatabase(c => c.DailyPrice > min && c.DailyPrice < max).ToList();
        return new SuccessDataResult<List<Car>>(Messages.ListedAllCar, carsToGet);
    }

    // Find a car based on `carId`
    public IDataResult<Car> GetCarById(int carId)
    {
        var carToGet = _carDal.GetFromDatabase(c => c.Id == carId);
        return new SuccessDataResult<Car>(carToGet);
    }

    // Add a car object
    public IResult Add(Car car)
    {
        if (car.ModelName.Length < 2 && car.DailyPrice < 0)
        {
            return new ErrorResult(Messages.InvalidCarOperation);
        }
        _carDal.AddToDatabase(car);
        return new SuccessResult(Messages.CarAdded);
    }

    // Update a car object
    public IResult Update(Car car)
    {
        _carDal.UpdateInDatabase(car);
        return new SuccessResult(Messages.CarUpdated);
    }

    // Delete a car object
    public IResult Delete(Car car)
    {
        _carDal.DeleteFromDatabase(car);
        return new SuccessResult(Messages.CarDeleted);
    }
}
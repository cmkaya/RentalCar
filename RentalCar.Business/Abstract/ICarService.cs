using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;

namespace RentalCar.Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAllCars();
    IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
    IDataResult<List<CarDetailsDto>> GetCarDetails();
    IDataResult<Car> GetCarById(int carId);
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
}
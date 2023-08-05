using Core.Utilities.Results;
using Entity.Concrete;

namespace RentalCar.Business.Abstract;

public interface IUserService
{
    IDataResult<List<User>> GetAllUsers();
    IDataResult<User> GetUserById(int userId);
    IResult Add(User user);
    IResult Update(User user);
    IResult Delete(User user);
}
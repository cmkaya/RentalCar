using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Abstract;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Concrete;

public class UserManager : IUserService
{
    private IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }
    
    // Retrieve all users
    public IDataResult<List<User>> GetAllUsers()
    {
        var usersToGet = _userDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<User>>(Messages.ListedAllUsers, usersToGet);
    }

    // Find a user by `userId`
    public IDataResult<User> GetUserById(int userId)
    {
        var userToGet = _userDal.GetFromDatabase(u => u.Id == userId);
        return new SuccessDataResult<User>(Messages.RetrievedUser);
    }

    // Add an user object
    public IResult Add(User user)
    {
        _userDal.AddToDatabase(user);
        return new SuccessResult(Messages.UserAdded);
    }

    // Update an user object
    public IResult Update(User user)
    {
        _userDal.UpdateInDatabase(user);
        return new SuccessResult(Messages.UserUpdated);
    }

    // Delete an user object
    public IResult Delete(User user)
    {
        _userDal.DeleteFromDatabase(user);
        return new SuccessResult(Messages.UserDeleted);
    }
}
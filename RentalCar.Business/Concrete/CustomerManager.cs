using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Abstract;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Concrete;

public class CustomerManager : ICustomerService
{
    private ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    // Retrieve all customers
    public IDataResult<List<Customer>> GetAllCustomers()
    {
        var customersToGet = _customerDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<Customer>>(Messages.ListedAllCustomers, customersToGet);
    }

    // Find a customer by `userId`
    public IDataResult<Customer> GetCustomerById(int customerId)
    {
        var customerToGet = _customerDal.GetFromDatabase(c => c.UserId == customerId);
        return new SuccessDataResult<Customer>(Messages.RetrievedCustomer);
    }

    // Add a customer object
    public IResult Add(Customer customer)
    {
        _customerDal.AddToDatabase(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    // Update a customer object
    public IResult Update(Customer customer)
    {
        _customerDal.UpdateInDatabase(customer);
        return new SuccessResult(Messages.CustomerUpdated);
    }

    // Delete a customer object
    public IResult Delete(Customer customer)
    {
        _customerDal.DeleteFromDatabase(customer);
        return new SuccessResult(Messages.CustomerDeleted);
    }
}
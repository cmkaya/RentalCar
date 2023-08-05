using Core.Utilities.Results;
using Entity.Concrete;

namespace RentalCar.Business.Abstract;

public interface ICustomerService
{
    IDataResult<List<Customer>> GetAllCustomers();
    IDataResult<Customer> GetCustomerById(int customerId);
    IResult Add(Customer customer);
    IResult Update(Customer customer);
    IResult Delete(Customer customer);
}
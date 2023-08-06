using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Data;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfRentalDal : EfEntityRepositoryBase<Rental, ApplicationDbContext>, IRentalDal
{
    
}
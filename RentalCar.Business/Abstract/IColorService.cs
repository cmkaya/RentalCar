using Core.Utilities.Results;
using Entity.Concrete;

namespace RentalCar.Business.Abstract;

public interface IColorService
{
    IDataResult<List<Color>> GetAllColors();
    IDataResult<Color> GetColorById(int colorId);
    IResult Add(Color color);
    IResult Update(Color color);
    IResult Delete(Color color);
}
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using RentalCar.Business.Constants;

namespace RentalCar.Business.Abstract;

public interface IColorService
{
    IDataResult<List<Color>> GetAllColors();
    IDataResult<Color> GetColorById(int colorId);
    IResult Add(Color color);
    IResult Update(Color color);
    IResult Delete(Color color);
}

public class ColorManager : IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    // Retrieve all colors.
    public IDataResult<List<Color>> GetAllColors()
    {
        var colorsToGet = _colorDal.GetAllFromDatabase().ToList();
        return new SuccessDataResult<List<Color>>(Messages.ListedAllColors, colorsToGet);
    }

    // Retrieve a color by `colorId`.
    public IDataResult<Color> GetColorById(int colorId)
    {
        var colorToGet = _colorDal.GetFromDatabase(c => c.Id == colorId);
        return new SuccessDataResult<Color>(Messages.FoundColor);
    }

    // Add a color.
    public IResult Add(Color color)
    {
        _colorDal.AddToDatabase(color);
        return new SuccessResult(Messages.ColorAdded);
    }

    // Update a color.
    public IResult Update(Color color)
    {
        _colorDal.UpdateInDatabase(color);
        return new SuccessResult(Messages.ColorUpdated);
    }

    // Delete a color.
    public IResult Delete(Color color)
    {
        _colorDal.DeleteFromDatabase(color);
        return new SuccessResult(Messages.ColorDeleted);
    }
}
namespace Core.Utilities.Results;

public interface IDataResult<out TData> : IResult
{
    public TData Data { get; }
}
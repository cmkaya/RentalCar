namespace Core.Utilities.Results;

public abstract class DataResult<TData> : Result, IDataResult<TData>
{
    public TData Data { get; }

    protected DataResult(bool success, TData data) : base(success)
    {
        Data = data;
    }
    
    protected DataResult(bool success, string message, TData data) : base(success, message)
    {
        Data = data;
    }
}
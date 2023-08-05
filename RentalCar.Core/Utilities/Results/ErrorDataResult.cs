namespace Core.Utilities.Results;

public class ErrorDataResult<TData> : DataResult<TData>
{
    public ErrorDataResult() : base(false, default)
    {
    }
    
    public ErrorDataResult(TData data) : base(false, data)
    {
    }

    public ErrorDataResult(string message) : base(false, message, default)
    {
    }

    public ErrorDataResult(string message, TData data) : base(false, message, data)
    {
    }
}
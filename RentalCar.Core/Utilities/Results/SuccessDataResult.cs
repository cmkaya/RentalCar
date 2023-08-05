namespace Core.Utilities.Results;

public class SuccessDataResult<TData> : DataResult<TData>
{
    public SuccessDataResult() : base(true, default)
    {
    }

    public SuccessDataResult(TData data) : base(true, data)
    {
    }
    
    public SuccessDataResult(string message) : base(true, message, default)
    {
    }
    
    public SuccessDataResult(string message, TData data) 
        : base(true, message, data)
    {
    }
}
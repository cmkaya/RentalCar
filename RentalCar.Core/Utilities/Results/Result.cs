namespace Core.Utilities.Results;

public abstract class Result : IResult
{
    public string Message { get; }
    public bool Success { get; }

    protected Result(bool success)
    {
        Success = success;
    }

    protected Result(bool success, string message) : this(success)
    {
        Message = message;
    }
}
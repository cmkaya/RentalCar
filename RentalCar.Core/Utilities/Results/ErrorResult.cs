namespace Core.Utilities.Results;

public class ErrorResult : Result
{
    // Since the default value `false` for the `Success`,
    // no need to declare a parameter for it.
    public ErrorResult() : base(false)
    {
    }

    public ErrorResult(string message) : base(false, message)
    {
    }
}
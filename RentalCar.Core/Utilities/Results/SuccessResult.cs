namespace Core.Utilities.Results;

public class SuccessResult : Result
{
    // Since the default value `true` for the `Success`,
    // no need to declare a parameter for it.
    public SuccessResult() : base(true)
    {
    }

    public SuccessResult(string message) : base(true, message)
    {
    }
}
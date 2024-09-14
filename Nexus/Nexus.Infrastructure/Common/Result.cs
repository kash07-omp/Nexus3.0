namespace Nexus.Infrastructure.Common
{
    public class Result<T>
    {
        public bool Success { get; private set; }
        public T? Value { get; private set; }
        public string ErrorMessage { get; private set; }

        private Result(bool success, T? value, string errorMessage)
        {
            Success = success;
            Value = value;
            ErrorMessage = errorMessage;
        }

        public static Result<T> SuccessResult(T value) => new Result<T>(true, value, string.Empty);
        public static Result<T> FailureResult(string errorMessage) => new Result<T>(false, default, errorMessage);
    }
}

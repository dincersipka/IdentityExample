using IdentityExample.Application.Abstractions.Wrappers;

namespace IdentityExample.Application.Wrappers
{
    public class SuccessResponse<T> : IServiceResponse
    {
        public T Value { get; set; }

        public string Message { get; private set; } = "Success.";

        public bool IsSuccess { get; private set; } = true;

        public SuccessResponse(T Value)
        {
            this.Value = Value;
        }
    }
}

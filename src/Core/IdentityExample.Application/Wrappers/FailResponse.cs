using IdentityExample.Application.Abstractions.Wrappers;

namespace IdentityExample.Application.Wrappers
{
    public class FailResponse : IServiceResponse
    {
        public string Message { get; set; }

        public bool IsSuccess { get; private set; } = false;

        public FailResponse(string Message)
        {
            this.Message = Message;
        }
    }
}

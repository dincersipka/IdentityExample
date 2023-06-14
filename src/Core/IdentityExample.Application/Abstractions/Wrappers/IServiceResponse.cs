namespace IdentityExample.Application.Abstractions.Wrappers
{
    public interface IServiceResponse
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}

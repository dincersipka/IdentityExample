namespace IdentityExample.Application.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base() { }
        public UserNotFoundException(string Message) : base(Message) { }
        public UserNotFoundException(string Message, Exception InnerException) : base(Message, InnerException) { }
    }
}

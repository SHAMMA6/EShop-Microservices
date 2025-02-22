
namespace Ordering.Domain.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException(string message) 
            : base($"Domain Exception\"{message}\" throws from Domain Layer.")
        {
        }
    }
}

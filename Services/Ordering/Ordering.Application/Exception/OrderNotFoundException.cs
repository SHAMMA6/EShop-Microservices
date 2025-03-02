using BuildingBlocks.Exceptions;

namespace Ordering.Application.Exception
{
    public class OrderNotFoundException : NotFoundException
    {
        public OrderNotFoundException(Guid id)
            : base($"Order with id {id}")
        {
        }
    }
}

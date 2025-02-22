namespace Ordering.Domain.Abstraction
{
    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? LastModifiedBy { get; set; }
    }
}

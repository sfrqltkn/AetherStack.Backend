using AetherStack.Backend.Domain.Absractions;

namespace AetherStack.Backend.Domain.Events
{
    public sealed class ProductSoftDeletedEvent : IDomainEvent
    {
        public int ProductId { get; }
        public string Name { get; }
        public DateTime OccurredOn { get; }

        public ProductSoftDeletedEvent(int productId, string name)
        {
            ProductId = productId;
            Name = name;
            OccurredOn = DateTime.UtcNow;
        }
    }
}

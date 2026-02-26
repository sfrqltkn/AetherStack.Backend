using AetherStack.Backend.Domain.Absractions;

namespace AetherStack.Backend.Domain.Events
{
    public sealed class ProductPriceChangedEvent : IDomainEvent
    {
        public int ProductId { get; }
        public decimal NewPrice { get; }
        public DateTime OccurredOn { get; }

        public ProductPriceChangedEvent(int productId, decimal newPrice)
        {
            ProductId = productId;
            NewPrice = newPrice;
            OccurredOn = DateTime.UtcNow;
        }
    }
}

namespace AetherStack.Backend.Domain.Absractions
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }
}

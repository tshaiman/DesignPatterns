namespace CommerceProject.Model.Rules
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
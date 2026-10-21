namespace RefactoringLab;

public interface IShippingCostCalculator
{
    decimal Calculate(decimal weightKg);
}
public class AramexShippingCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}
public class FedExShippingCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}
public class DHLShippingCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}

public class ShippingCostCalculator 
{
    IShippingCostCalculator shippingCostCalculator;
    public ShippingCostCalculator(IShippingCostCalculator shippingCostCalculator)
    {
        this.shippingCostCalculator = shippingCostCalculator;
    }
    public decimal Calculate(decimal weightKg)
    {
        return shippingCostCalculator.Calculate(weightKg);
    }
}

    

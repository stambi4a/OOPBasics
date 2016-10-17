namespace Kermen.Models.Interfaces
{
    public interface IMoneyEarner : IPerson
    {
        double PaymentPerMonth { get; }
    }
}

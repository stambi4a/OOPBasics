namespace Kermen.Models
{
    using Kermen.Models.Interfaces;

    public class MoneyEarningPerson : Person, IMoneyEarner
    {
        public MoneyEarningPerson(double montlyPayment)
        {
            this.PaymentPerMonth = montlyPayment;
        }

        public double PaymentPerMonth { get; protected set; }
    }
}

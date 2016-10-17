namespace Kermen.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Kermen.Models.Interfaces;

    public abstract class Home : IHome
    {
        protected Home(IList<IList<double>> homeParams, int roomCount, double roomUpkeepCost)
        {
            this.AddOwners(homeParams[0]);
            this.AddElectricalConsumers(homeParams);
            this.AddRooms(roomCount, roomUpkeepCost);
            this.CalculateHomeIncome();
            this.CalculateHomeExpense();
        }

        public double HomeBudgetExpenses { get; protected set; }

        public double HomeBudgetIncome { get; private set; }

        public double HomeBudget { get; private set; }

        public virtual int PopulationCount => this.Owners.Count;

        public IEnumerable<IRoom> Rooms { get; private set; }

        public ICollection<IElectricalConsumer> ElectricalUtilityConsumers { get; protected set; }

        public ICollection<IMoneyEarner> Owners { get; private set; }

        public void AddIncome()
        {
            this.HomeBudget += this.HomeBudgetIncome;
        }

        public void SubtractExpenses()
        {
            this.HomeBudget -= this.HomeBudgetExpenses;
        }

        protected virtual void CalculateHomeExpense()
        {
            this.HomeBudgetExpenses = this.Rooms.Sum(room => room.CostPerMonth)
                                     + this.ElectricalUtilityConsumers.Sum(
                                         electricityConsumer => electricityConsumer.CostPerMonth);
        }

        protected void CalculateHomeIncome()
        {
            this.HomeBudgetIncome = this.Owners.Sum(owner => owner.PaymentPerMonth);
        }

        protected void AddOwners(ICollection<double> montlyPayments)
        {
            this.Owners = new List<IMoneyEarner>();
            foreach (var monthlyPayment in montlyPayments)
            {
                this.Owners.Add(new MoneyEarningPerson(monthlyPayment));
            }
        }

        protected abstract void AddElectricalConsumers(IList<IList<double>> homeParams);

        protected void AddRooms(int roomCount, double roomCost)
        {
            this.Rooms = Enumerable.Repeat(new Room(roomCost), roomCount);
        }
    }
}

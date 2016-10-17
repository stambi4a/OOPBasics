namespace Kermen.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IHome
    {
        double HomeBudgetExpenses { get; }

        int PopulationCount { get; }

        double HomeBudgetIncome { get; }

        double HomeBudget { get; }

        IEnumerable<IRoom> Rooms { get; }

        ICollection<IElectricalConsumer> ElectricalUtilityConsumers { get; }

        ICollection<IMoneyEarner> Owners { get; }

        void AddIncome();

        void SubtractExpenses();
    }
}

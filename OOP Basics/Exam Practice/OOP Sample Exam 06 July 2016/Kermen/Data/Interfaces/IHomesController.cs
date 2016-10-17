namespace Kermen.Data.Interfaces
{
    using System.Collections.Generic;

    using Kermen.Models.Interfaces;

    public interface IHomesController
    {
        IDatabase Database { get; }

        void AddHome(IHome home);

        void RemoveHome(IHome home);

        ICollection<IHome> PayBills();

        void PaySalariesAndPensions();

        void PrintTotalPopulation();

        void PrintTotalConsumption();
    }
}

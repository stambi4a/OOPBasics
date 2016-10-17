namespace Kermen.Data
{
    using System.Collections.Generic;

    using Kermen.Data.Interfaces;
    using Kermen.Models.Interfaces;
    using Kermen.UserInterface.Interfaces;

    public class HomesController : IHomesController
    {
        public HomesController(IDatabase database, IUserInterface userInterface)
        {
            this.Database = database;
            this.UserInterface = userInterface;
        }

        public IDatabase Database { get; }

        public IUserInterface UserInterface { get; set; } 

        public int TotalPopulation { get; private set; }

        public double TotalConsumption { get; private set; }


        public void AddHome(IHome home)
        {
            this.Database.Homes.Add(home);
            this.TotalPopulation += home.PopulationCount;
            this.TotalConsumption += home.HomeBudgetExpenses;
        }

        public void RemoveHome(IHome home)
        {
            this.Database.Homes.Remove(home);
            this.TotalPopulation -= home.PopulationCount;
            this.TotalConsumption -= home.HomeBudgetExpenses;
        }

        public ICollection<IHome> PayBills()
        {
            var homesThatCanNotPay = new List<IHome>();
            foreach (var home in this.Database.Homes)
            {
                home.SubtractExpenses();
                if (home.HomeBudget < 0)
                {
                    homesThatCanNotPay.Add(home);
                }
            }

            return homesThatCanNotPay;
        }

        public void PaySalariesAndPensions()
        {
            foreach (var home in this.Database.Homes)
            {
                home.AddIncome();
            }
        }

        public void PrintTotalPopulation()
        {
            this.UserInterface.WriteLine("Total population: " + this.TotalPopulation); 
        }

        public void PrintTotalConsumption()
        {
            this.UserInterface.WriteLine("Total Consumption: " + this.TotalConsumption);
        }
    }
}

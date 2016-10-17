namespace Kermen.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Kermen.Models.Interfaces;

    public class YoungCoupleWithChildrenHome : YoungCoupleHome
    {
        private const int DefaultYoungCoupleWithChildrenHomeRoomCount = 2;
        private const double DefaultYoungCoupleWithChildrenHomeRoomElectricityCost = 30;

        public YoungCoupleWithChildrenHome(
             IList<IList<double>> homeParams, 
            int roomCount = DefaultYoungCoupleWithChildrenHomeRoomCount,
            double roomUpkeepCost = DefaultYoungCoupleWithChildrenHomeRoomElectricityCost)
            : base(
                  homeParams,
                  roomCount, 
                  roomUpkeepCost)
        {
            this.AddChildren(homeParams.Skip(4).ToList());
            this.AddChildrenToysToelectricalConsumers();
        }

        public YoungCoupleWithChildrenHome(IList<IList<double>> homeParams)
           : base(
                 homeParams,
                 DefaultYoungCoupleWithChildrenHomeRoomCount,
                 DefaultYoungCoupleWithChildrenHomeRoomElectricityCost)
        {
            this.AddChildren(homeParams.Skip(4).ToList());
            this.AddChildrenToysToelectricalConsumers();
            base.CalculateHomeExpense();
            this.AddChildrenExpense();
        }

        public ICollection<Child> Children { get; private set; }

        public override int PopulationCount => base.PopulationCount + this.Children.Count;
        protected void AddChildrenExpense()
        {
            base.HomeBudgetExpenses += this.Children.Sum(child => child.CostPerMonth);
        }

        protected override void AddElectricalConsumers(IList<IList<double>> homeParams)
        {
            base.ElectricalUtilityConsumers = new List<IElectricalConsumer>();
            var fridge = new Fridge(homeParams[1][0]);
            var tvSet = new TelevisionSet(homeParams[2][0]);
            var laptopCost = homeParams[3][0];
            this.ElectricalUtilityConsumers.Add(fridge);
            this.ElectricalUtilityConsumers.Add(tvSet);
            for (var i = 0; i < DefaultYoungCoupleHomeLaptopCount; i++)
            {
                this.ElectricalUtilityConsumers.Add(new Laptop(laptopCost));
            }
        }

        private void AddChildrenToysToelectricalConsumers()
        {
            var allChildToys = this.Children.SelectMany(child => child.Toys);
            foreach (var toy in allChildToys)
            {
                this.ElectricalUtilityConsumers.Add(toy);
            }
        }

        private void AddChildren(ICollection<IList<double>> childrenExpenses)
        {
            if (childrenExpenses == null)
            {
                throw new ArgumentNullException(nameof(childrenExpenses));
            }

            this.Children = new List<Child>();
            foreach (var childExpenses in childrenExpenses)
            {
                var foodCost = childExpenses[0];
                var toys = childExpenses.Skip(1).Select(toyCost => new Toy(toyCost));
                var child = new Child(toys, foodCost);
                this.Children.Add(child);
            }
        }
    }
}

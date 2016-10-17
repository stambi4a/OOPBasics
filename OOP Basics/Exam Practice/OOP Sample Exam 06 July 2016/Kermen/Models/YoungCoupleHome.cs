namespace Kermen.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Kermen.Models.Interfaces;

    public class YoungCoupleHome : Home
    {
        private const int DefaultYoungCoupleHomeRoomCount = 2;
        private const double DefaultYoungCoupleHomeRoomElectricityCost = 20;
        protected const int DefaultYoungCoupleHomeLaptopCount = 2;

        public YoungCoupleHome(
             IList<IList<double>> homeParams,
            int roomCount = DefaultYoungCoupleHomeRoomCount,
            double roomUpkeepCost = DefaultYoungCoupleHomeRoomElectricityCost)
            : base(
                  homeParams,
                  roomCount, 
                  roomUpkeepCost)
        {
        }

        public YoungCoupleHome(IList<IList<double>> homeParams)
           : base(
                 homeParams,
                 DefaultYoungCoupleHomeRoomCount,
                 DefaultYoungCoupleHomeRoomElectricityCost)
        {
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
    }
}

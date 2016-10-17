namespace Kermen.Models
{
    using System.Collections.Generic;

    using Kermen.Models.Interfaces;

    public class OldCoupleHome : Home
    {
        private const int DefaultOldCoupleHomeRoomCount = 3;
        private const double DefaultOldCoupleHomeRoomElectricityCost = 15;

        public OldCoupleHome(
            IList<IList<double>> homeParams,
            int roomCount = DefaultOldCoupleHomeRoomCount,
            double roomUpkeepCost = DefaultOldCoupleHomeRoomElectricityCost)
            : base(homeParams, roomCount, roomUpkeepCost)
        {
        }

        public OldCoupleHome(IList<IList<double>> homeParams)
            : base(homeParams, DefaultOldCoupleHomeRoomCount, DefaultOldCoupleHomeRoomElectricityCost)
        {

        }

        protected override void AddElectricalConsumers(IList<IList<double>> homeParams)
        {
            base.ElectricalUtilityConsumers = new List<IElectricalConsumer>();
            var fridge = new Fridge(homeParams[1][0]);
            var tvSet = new TelevisionSet(homeParams[2][0]);
            var stove = new Stove(homeParams[3][0]);
            this.ElectricalUtilityConsumers.Add(fridge);
            this.ElectricalUtilityConsumers.Add(tvSet);
            this.ElectricalUtilityConsumers.Add(stove);
        }
    }
}

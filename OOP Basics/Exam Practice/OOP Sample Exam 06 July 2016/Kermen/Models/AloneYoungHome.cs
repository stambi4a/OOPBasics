namespace Kermen.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;

    public class AloneYoungHome : Home
    {
        private const int DefaultAloneYoungHomeRoomCount = 1;
        private const int DefaultAloneYoungHomeLaptopCount = 1;
        private const double DefaultAloneYoungHomeRoomElectricityCost = 10;

        public AloneYoungHome(
            IList<IList<double>> homeParams,
            int roomCount = DefaultAloneYoungHomeRoomCount,
            double roomUpkeepCost = DefaultAloneYoungHomeRoomElectricityCost)
            : base(homeParams, roomCount, roomUpkeepCost)
        {
        }



        public AloneYoungHome(IList<IList<double>> homeParams)
            : base(homeParams, DefaultAloneYoungHomeRoomCount, DefaultAloneYoungHomeRoomElectricityCost)
        {

        }

        protected override void AddElectricalConsumers(IList<IList<double>> homeParams)
        {
            base.ElectricalUtilityConsumers = Enumerable.Repeat(
                new Laptop(homeParams[1][0]), 
                DefaultAloneYoungHomeLaptopCount) as ICollection<IElectricalConsumer>;
        }
    }
}

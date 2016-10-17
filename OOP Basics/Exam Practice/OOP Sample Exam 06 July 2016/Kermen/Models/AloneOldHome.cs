namespace Kermen.Models
{
    using System.Collections.Generic;

    public class AloneOldHome : Home
    {
        private const int DefaultAloneOldHomeRoomCount = 1;
        private const double DefaultAloneOldHomeRoomElectricityCost = 15;

        public AloneOldHome(
           IList<IList<double>> homeParams,
            int roomCount = DefaultAloneOldHomeRoomCount, 
            double roomUpkeepCost = DefaultAloneOldHomeRoomElectricityCost) 
            : base(
                  homeParams,
                  roomCount, 
                  roomUpkeepCost)
        {
           
        }

        public AloneOldHome(IList<IList<double>> homeParams)
            : base(
                  homeParams,
                  DefaultAloneOldHomeRoomCount,
                  DefaultAloneOldHomeRoomElectricityCost)
        {

        }

        protected override void AddElectricalConsumers(IList<IList<double>> homeParams)
        {           
        }
    }
}

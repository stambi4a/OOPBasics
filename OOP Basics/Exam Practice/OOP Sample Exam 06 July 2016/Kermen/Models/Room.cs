namespace Kermen.Models
{
    using Kermen.Models.Interfaces;

    public class Room : ElectricalConsumer, IRoom
    {
        public Room(double cost) : base(cost)
        {
        }
    }
}

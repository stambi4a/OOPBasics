namespace Vegetable_Ninja.Core.Interfaces
{
    using System.Collections.Generic;

    using Models.Interfaces;

    public interface IDatabase : IBattleGround
    {
        LinkedList<INinja> Ninjas { get; }

        IDictionary<INinja, int[]> NinjaCoordinates { get; }

        IGarden Garden { get; }

        INinja CurrentNinja { get; }

        int[] CurrentNinjaCoordinates { get; }

        void Update();

        void CurrentNinjaGatherVegetables();
    }
}

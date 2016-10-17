namespace Vegetable_Ninja.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IGarden : IMatrix
    {
        IList<IList<char>> GardenLayout { get; }

        IList<IList<int>> RegrowMovesGardenLayout { get; }

        void RegrowVegetables(IDictionary<INinja, int[]> ninjaCoordinates);

        void PlaceBlankSpaces(IReadOnlyList<int[]> coordinates);
    }
}

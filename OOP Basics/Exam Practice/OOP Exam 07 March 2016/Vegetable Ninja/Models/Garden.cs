namespace Vegetable_Ninja.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class Garden : IGarden
    {
        public const char BlankSpaceGardenValue = '-';
        public Garden(int rows, int columns, IList<string> rowLayouts)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.SetGardenLayout(rowLayouts);
            this.SetRegrowMovesLayout();
        }

        public int Rows { get; }

        public int Columns { get; }

        public IList<IList<char>> GardenLayout { get; set; }

        public IList<IList<int>> RegrowMovesGardenLayout { get; set; }

        private void SetGardenLayout(IList<string> rowLayouts)
        {
            this.GardenLayout = new List<IList<char>>();
            foreach (var rowLayout in rowLayouts)
            {
                this.GardenLayout.Add(rowLayout.ToCharArray());
            }
        }

        private void SetRegrowMovesLayout()
        {
            this.RegrowMovesGardenLayout = new List<IList<int>>(this.Rows);
            for (var i = 0; i < this.Rows; i++)
            {
                this.RegrowMovesGardenLayout.Add(new int[this.Columns]);
            }
        }

        public void RegrowVegetables(IDictionary<INinja, int[]> ninjasCoordinates)
        {
            for (var i = 0; i < this.Rows; i++)
            {
                for (var j = 0; j < this.Columns; j++)
                {
                    this.GrowVegetable(i, j);
                }
            }

            this.DelayRegrowStampedVegetables(ninjasCoordinates);
        }

        public void PlaceBlankSpaces(IReadOnlyList<int[]> coordinates)
        {
            foreach (var coordinateArray in coordinates)
            {
                this.GardenLayout[coordinateArray[0]][coordinateArray[1]] = BlankSpaceGardenValue;
            }
        }

        private void GrowVegetable(int row, int column)
        {
            this.RegrowMovesGardenLayout[row][column] -= this.RegrowMovesGardenLayout[row][column] > 0 ? 1 : 0;
        }

        private void DelayRegrowStampedVegetables(IDictionary<INinja, int[]> ninjasCoordinates)
        {
            foreach (var coordinates in ninjasCoordinates.Values)
            {
                this.RegrowMovesGardenLayout[
                    coordinates[0]][coordinates[1]] += this.GardenLayout[coordinates[0]][coordinates[1]] != '-' ? 1 : 0;
            }
        }
    }
}

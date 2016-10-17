namespace Vegetable_Ninja.Core
{
    using System.Collections.Generic;

    using Interfaces;
    using Models.Interfaces;

    using Factories;

    public class Database : IDatabase
    {
        public Database(IGarden garden, LinkedList<INinja> ninjas, IDictionary<INinja, int[]> ninjaCoordinates, INinja firstNinja)
        {
            this.Garden = garden;
            this.NinjaCoordinates = ninjaCoordinates;
            this.Ninjas = ninjas;
            this.CurrentNinja = firstNinja;
            this.CurrentNinjaCoordinates = ninjaCoordinates[firstNinja];
        }
        public LinkedList<INinja> Ninjas { get; }

        public IDictionary<INinja, int[]> NinjaCoordinates { get; }

        public IGarden Garden { get; }

        public INinja CheckIfAttacksAnotherNinja()
        {
            this.UpdateCurrentNinjaStamina();
            foreach (var ninja in this.NinjaCoordinates)
            {
                if (!ninja.Key.Equals(this.CurrentNinja) && ninja.Value[0] == this.CurrentNinjaCoordinates[0] && ninja.Value[1] == this.CurrentNinjaCoordinates[1])
                {
                    return this.CurrentNinja.Power >= ninja.Key.Power ? this.CurrentNinja : ninja.Key;
                }
            }

            return null;
        }

        public void CurrentNinjaGatherVegetables()
        {
            if (this.Garden.RegrowMovesGardenLayout[this.CurrentNinjaCoordinates[0]][this.CurrentNinjaCoordinates[1]]
                > 0)
            {
                return;
            }

            var vegetable = VegetableFactory.CreateVegetable(
                this.Garden.GardenLayout[this.CurrentNinjaCoordinates[0]][this.CurrentNinjaCoordinates[1]]);
            if (vegetable != null)
            {
                this.CurrentNinja.CollectVegetable(vegetable);
                this.Garden.RegrowMovesGardenLayout[this.CurrentNinjaCoordinates[0]][this.CurrentNinjaCoordinates[1]] =
                    vegetable.PlayerMovesToRegrow;
            }
        }

        public INinja CurrentNinja { get; private set; }

        public int[] CurrentNinjaCoordinates { get; private set; }

        public void Update()
        {
            if (this.CurrentNinja.Stamina == 0)
            {
                this.CurrentNinja.EatVegetables();
                this.CurrentNinja = this.CurrentNinja.Equals(this.Ninjas.Last.Value) ? this.Ninjas.First.Value : this.Ninjas.Find(this.CurrentNinja).Next.Value;
            }

            this.CurrentNinjaCoordinates = this.NinjaCoordinates[this.CurrentNinja];
            this.Garden.RegrowVegetables(this.NinjaCoordinates);
        }

        private void UpdateCurrentNinjaStamina()
        {
            this.CurrentNinja.Stamina--;
        }
    }
}

namespace Vegetable_Ninja.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IVegetableConsumer
    {
        ICollection<IVegetable> Vegetables { get; }

        void CollectVegetable(IVegetable vegetable);

        void EatVegetables();
    }
}

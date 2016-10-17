namespace Vegetable_Ninja.Factories
{
    using Vegetable_Ninja.Models;
    using Vegetable_Ninja.Models.Interfaces;

    public class NinjaFactory
    {
        public static INinja CreateNinja(string name)
        {
            return new Ninja(name);
        }
    }
}

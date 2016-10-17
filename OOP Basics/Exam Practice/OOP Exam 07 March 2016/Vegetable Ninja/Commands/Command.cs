namespace Vegetable_Ninja.Commands
{
    using Interfaces;

    using Models.Interfaces;

    public abstract class Command : ICommand
    {
        public abstract void Execute(int[] currentNinjaCoordinates, IGarden garden);
    }
}

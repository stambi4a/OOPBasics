namespace Vegetable_Ninja.Commands.Interfaces
{
    using Vegetable_Ninja.Models.Interfaces;

    public interface ICommandExecutor
    {
        void Execute(char commandValue, int[] currentNinjaCoordinates, IGarden garden);
    }
}

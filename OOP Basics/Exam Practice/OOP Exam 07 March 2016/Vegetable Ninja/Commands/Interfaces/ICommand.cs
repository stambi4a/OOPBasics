namespace Vegetable_Ninja.Commands.Interfaces
{
    using Vegetable_Ninja.Models.Interfaces;

    public interface ICommand
    {
        void Execute(int[] currentNinjaCoordinates, IGarden garden);
    }
}

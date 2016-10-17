namespace Vegetable_Ninja.Commands
{
    using Vegetable_Ninja.Models.Interfaces;

    public class RCommand : Command
    {
        public override void Execute(int[] currentNinjaCoordinates, IGarden garden)
        {
            if (currentNinjaCoordinates[1] < garden.Columns - 1)
            {
                currentNinjaCoordinates[1]++;
            }
        }
    }
}

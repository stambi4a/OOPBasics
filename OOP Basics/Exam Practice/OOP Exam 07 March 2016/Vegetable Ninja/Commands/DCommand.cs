namespace Vegetable_Ninja.Commands
{
    using Vegetable_Ninja.Models.Interfaces;

    public class DCommand : Command
    {
        public override void Execute(int[] currentNinjaCoordinates, IGarden garden)
        {
            if (currentNinjaCoordinates[0] < garden.Rows - 1)
            {
                currentNinjaCoordinates[0]++;
            }
        }
    }
}

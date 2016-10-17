namespace Vegetable_Ninja.Commands
{
    using Vegetable_Ninja.Models.Interfaces;

    public class LCommand : Command
    {
        public override void Execute(int[] currentNinjaCoordinates, IGarden garden)
        {
            if (currentNinjaCoordinates[1] > 0)
            {
                currentNinjaCoordinates[1]--;
            }
        }
    }
}

namespace Vegetable_Ninja.Commands
{
    using Vegetable_Ninja.Models.Interfaces;

    public class UCommand : Command
    {
        public override void Execute(int[] currentNinjaCoordinates, IGarden garden)
        {
            if (currentNinjaCoordinates[0] > 0)
            {
                currentNinjaCoordinates[0]--;
            }
        }
    }
}

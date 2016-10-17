namespace Kermen.Commands
{
    public class RegisterAloneYoungPersonCommand : RegisterHomeCommand
    {
        private const string AloneYoungPersonHomeName = "AloneYoungHome";

        public RegisterAloneYoungPersonCommand()
                : base(AloneYoungPersonHomeName)
            {
        }
    }
}

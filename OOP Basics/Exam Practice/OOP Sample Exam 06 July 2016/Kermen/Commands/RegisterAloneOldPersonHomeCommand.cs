namespace Kermen.Commands
{
    public class RegisterAloneOldPersonHomeCommand : RegisterHomeCommand
    {
        private const string AloneOldPersonHomeName = "AloneOldHome";

        public RegisterAloneOldPersonHomeCommand()
            : base(AloneOldPersonHomeName)
        {
        }
    }
}

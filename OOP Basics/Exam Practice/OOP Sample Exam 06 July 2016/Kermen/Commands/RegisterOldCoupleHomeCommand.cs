namespace Kermen.Commands
{
    public class RegisterOldCoupleHomeCommand : RegisterHomeCommand
    {
        private const string OldCoupleHomeName = "OldCoupleHome";
        public RegisterOldCoupleHomeCommand()
                : base(OldCoupleHomeName)
            {
        }
    }
}

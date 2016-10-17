namespace Kermen.Commands
{
    public class RegisterYoungCoupleHomeCommand : RegisterHomeCommand
    {
        private const string YoungCoupleHomeName = "YoungCoupleHome";
       
        public RegisterYoungCoupleHomeCommand()
                : base(YoungCoupleHomeName)
        {
        }
    }
}

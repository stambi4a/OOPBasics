namespace System_Split.Commands
{
    public class RegisterLightSoftwareCommand : RegisterSoftwareCommand
    {
        private const string RegisterLightSoftwareName = "RegisterLightSoftware";

        public RegisterLightSoftwareCommand(string[] commandParams)
            : base(RegisterLightSoftwareName, commandParams)
        {
        }
    }
}

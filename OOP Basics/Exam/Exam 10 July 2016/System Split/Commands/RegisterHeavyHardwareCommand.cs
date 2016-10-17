namespace System_Split.Commands
{
    using System_Split.Data;

    public class RegisterHeavyHardwareCommand : RegisterHardwareCommand
    {
        private const string RegisterHeavyHardwareName = "RegisterHeavyHardware";

        public RegisterHeavyHardwareCommand(string[] commandParams)
            : base(RegisterHeavyHardwareName, commandParams)
        {

        }
    }
}

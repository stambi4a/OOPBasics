namespace System_Split.Commands
{
    public class RegisterPowerHardwareCommand: RegisterHardwareCommand
    {
        private const string RegisterPowerHardwareName = "RegisterPowerHardware";

        public RegisterPowerHardwareCommand(string[] commandParams)
            : base(RegisterPowerHardwareName, commandParams)
        {
        }
    }
}

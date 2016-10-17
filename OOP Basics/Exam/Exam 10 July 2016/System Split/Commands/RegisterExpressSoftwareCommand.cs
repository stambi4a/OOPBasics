namespace System_Split.Commands
{
    public class RegisterExpressSoftwareCommand : RegisterSoftwareCommand
    {
        private const string RegisterExpressSoftwareName = "RegisterExpressSoftware";
        public RegisterExpressSoftwareCommand(string[] commandParams)
            : base(RegisterExpressSoftwareName, commandParams)
        {
        } 
    }
}

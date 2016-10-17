namespace Kermen.UserInterface.Interfaces
{
    public interface IWriter
    {
        void Write(string result);

        void WriteLine(string result);

        void WriteLine(object obj);
    }
}

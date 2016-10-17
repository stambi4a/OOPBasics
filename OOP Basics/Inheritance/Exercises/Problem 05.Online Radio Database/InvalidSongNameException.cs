namespace Problem_05.Online_Radio_Database
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message)
            : base(message)
        {
            
        }
    }
}

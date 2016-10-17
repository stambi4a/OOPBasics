namespace Problem_05.Online_Radio_Database
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message)
            : base(message)
        {
            
        }
    }
}

namespace Problem_05.Online_Radio_Database
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message)
            : base(message)
        {
            
        }
    }
}

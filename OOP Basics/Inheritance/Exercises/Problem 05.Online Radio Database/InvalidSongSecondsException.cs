namespace Problem_05.Online_Radio_Database
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException(string message)
            : base(message)
        {
            
        }
    }
}

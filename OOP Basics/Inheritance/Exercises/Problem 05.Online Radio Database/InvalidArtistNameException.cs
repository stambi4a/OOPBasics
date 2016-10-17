namespace Problem_05.Online_Radio_Database
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message)
            : base(message)
        {
            
        }
    }
}

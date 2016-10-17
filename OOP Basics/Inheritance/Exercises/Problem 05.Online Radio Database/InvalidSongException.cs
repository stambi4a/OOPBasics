namespace Problem_05.Online_Radio_Database
{
    using System;
    public class InvalidSongException : Exception
    {
        public InvalidSongException(string message)
            : base(message)
        {
            
        }
    }
}

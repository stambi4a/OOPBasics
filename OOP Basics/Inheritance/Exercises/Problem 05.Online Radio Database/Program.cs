namespace Problem_05.Online_Radio_Database
{
    using System;
    using System.Numerics;

    internal class Program
    {
        private static void Main(string[] args)
        {

            var songsCount = long.Parse(Console.ReadLine());
            var playlist = new Playlist();
            for (var i = 0; i < songsCount; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(new[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    if (input.Length != 4)
                    {
                        continue;
                    }

                    var performer = input[0];
                    var title = input[1];
                    var minutes = 0L;
                    if(!long.TryParse(input[2],out minutes))
                    {
                        throw new InvalidSongLengthException("Invalid song length.");
                    };
                    var seconds = 0L;
                    if (!long.TryParse(input[3], out seconds))
                    {
                        throw new InvalidSongLengthException("Invalid song length.");
                    };
                    var song = new Song(performer, title, minutes, seconds);
                    playlist.AddSong(song);
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }               
            }

            Console.WriteLine(playlist);
        }
    }
}

using System;
using MusicApp;

  class program
{
    static void Main(string[] args)
    {
        MusicPlayerApp player = new MusicApp.MusicPlayerApp();

        string input = "";

        while (input != "q")
        {

            player.DefaultSongs();
            player.AddSong();
            player.PlaylistSongs();
            player.Shuffle();
            player.EditSongs();
            player.RemoveSong();
            player.AlphabeticPlay();
            player.PlaySong();
            player.NextSong();
            player.PreviousSong();
            player.CurrentlyPlaying();

        }
    }
}




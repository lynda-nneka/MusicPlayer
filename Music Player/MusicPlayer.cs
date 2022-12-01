using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{

    public class MusicPlayerApp
    {
        //public string[] songs = { "ototo", "orhanise", "buga" };
        List<string> songs = new List<string>();
        int playingSong = 0;

        public void DefaultSongs()
        {
            songs.Add("Ototo");
            songs.Add("Buga");
            songs.Add("Organise");
            songs.Add("End of The Road");
            songs.Add("Alone");
            songs.Add("Nzanza");

        }

        public void PlaySong()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Track Number. There are " + songs.Count.ToString() + " songs in this playlist");



            while (playingSong < 0 || playingSong > songs.Count)
            {
                try
                {
                    playingSong = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect Input");

                }
                catch (Exception)
                {
                    Console.WriteLine("Track does not exist");
                }
                
            }



            Console.WriteLine(songs[playingSong]);
        }

        public void AddSong()
        {
            Console.WriteLine("What's Your New Song's Name?");

            string songName = Console.ReadLine();

            songs.Add(songName);

            Console.WriteLine(songName.ToString() + " has been added to your playlist");
        }


        public void RemoveSong()
        {
            Console.WriteLine();
            Console.WriteLine("What song do you want to remove?");
            string songName = Console.ReadLine();

            if (songs.Contains(songName))
            {
                songs.Remove(songName);
                Console.WriteLine(songName.ToString() + " has been removed");

            }
            else
            {
                Console.WriteLine("Song doesn't Exist");
            }
        }


        public void EditSongs()
        {
            Console.WriteLine();
            Console.WriteLine("What song do you want to edit?");
            string songName = Console.ReadLine();

            if (songs.Contains(songName))
            {

                int index = songs.FindIndex(a => a.Contains(songName));

                Console.WriteLine(index.ToString());

                Console.WriteLine();
                Console.WriteLine("What should your new song's name be?");
                string editedSongName = Console.ReadLine();
                songs[index] = editedSongName;
            }
            else
            {
                Console.WriteLine("Song doesn't Exist / Incorrect Spelling");
            }

        }


        public void NextSong()
        {
            if (playingSong + 1 <= songs.Count - 1)
            {
                Console.WriteLine("Currently Playing " + songs[playingSong + 1]);
                Console.WriteLine("----------------------------------------------------"); 
                playingSong++;
            }
            else if (playingSong + 1 > songs.Count - 1)
            {
                Console.WriteLine("Currently Playing " + songs[0]);
                playingSong = 0;
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }


        public void PreviousSong()
        {
            Console.WriteLine();
            if (playingSong - 1 >= 0)
            {
                Console.WriteLine("Currently Playing " + songs[playingSong - 1]);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(songs[playingSong - 1]);
                playingSong--;
            }
            else if (playingSong - 1 < 0)
            {
                playingSong = songs.Count - 1;
                Console.WriteLine("Currently Playing " + songs[playingSong]);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(songs[playingSong]);
            }
            Console.WriteLine("----------------------------------------------------");
        }


        public void CurrentlyPlaying()
        {
            Console.WriteLine("Currently Playing " + songs[playingSong]);
            Console.WriteLine("----------------------------------------------------");
        }


        public void NewPlaylist()
        {
            List<string> playlist = new List<string>();
            Console.WriteLine("What's Your Playlist Name?");
            string playlistName = Console.ReadLine();

            List<string> playlistNames = new List<string>();
        }


        public void PlaylistSongs()
        {
            Console.WriteLine("All Playlist Songs");
            Console.WriteLine("----------------------------------------------------");
            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine("----------------------------------------------------");
        }


        public void Shuffle()
        {
            int lastIndex = songs.Count - 1;
            while (lastIndex > 0)
            {
                string tempValue = songs[lastIndex];
                int randomIndex = new Random().Next(0, lastIndex);
                songs[lastIndex] = songs[randomIndex];  
                songs[randomIndex] = tempValue;
                lastIndex--;
            }
            Console.WriteLine();
            Console.WriteLine("Shuffled Songs Queue");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < songs.Count; i++)
            {

                Console.WriteLine(songs[i]);
            }
            Console.WriteLine("----------------------------------------------------");
        }


        public void AlphabeticPlay()
        {
            Console.WriteLine();
            Console.WriteLine("Alphabetically Organised");
            Console.WriteLine("----------------------------------------------------");
            songs.Sort((x, y) => string.Compare(x, y));
            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine("----------------------------------------------------");
        }


    }
}

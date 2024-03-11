using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace MyMusicPlayer
{
    public class MusicPlayer
    {
        private List<string> playlist = new List<string>();

        public void CreatePlaylist()
        {
            Console.Write("Enter song name to add to playlist: ");
            string songName = Console.ReadLine();
            playlist.Add(songName);
            Console.WriteLine($"{songName} added to playlist.");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing music...");
            // Implement music playback logic (e.g., load and play music files)
        }

        public void ShuffleMusic()
        {
            // Implement shuffle music logic (e.g., randomize playlist order)
            Console.WriteLine("Shuffling music...");
        }

        public void DeleteMusic()
        {
            Console.Write("Enter song name to delete from playlist: ");
            string songName = Console.ReadLine();
            if (playlist.Contains(songName))
            {
                playlist.Remove(songName);
                Console.WriteLine($"{songName} removed from playlist.");
            }
            else
            {
                Console.WriteLine($"{songName} not found in playlist.");
            }
        }
    }

    
    
}

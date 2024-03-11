namespace MyMusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer musicPlayer = new MusicPlayer();

            while (true)
            {
                Console.WriteLine("Music Player App");
                Console.WriteLine("1. Create Playlist");
                Console.WriteLine("2. Play Music");
                Console.WriteLine("3. Shuffle Music");
                Console.WriteLine("4. Delete Music");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        musicPlayer.CreatePlaylist();
                        break;
                    case 2:
                        musicPlayer.PlayMusic();
                        break;
                    case 3:
                        musicPlayer.ShuffleMusic();
                        break;
                    case 4:
                        musicPlayer.DeleteMusic();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Music Player App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

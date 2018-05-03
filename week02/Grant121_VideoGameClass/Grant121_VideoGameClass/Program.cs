using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_VideoGameClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayList(CreateList());

            Console.ReadKey();
        }

        static List<VideoGame> CreateList()
        {
            List<VideoGame> videoGames = new List<VideoGame>()
            {
                new VideoGame()
                {
                    Name = "Gurren Lagann",
                    Id = 50019,
                    Price = 4.99,
                    Platform = PlatformType.Switch,
                    VirtualReality = true
                },

                new VideoGame()
                {
                    Name = "Persona 4: Driving All Evening",
                    Id = 50020,
                    Price = 0,
                    Platform = PlatformType.Xbox,
                    VirtualReality = false
                }
            };

            videoGames.Add(new VideoGame("Dark Souls", 50015, 14.99, PlatformType.Jaguar, false));
            videoGames.Add(new VideoGame("Cup Head", 50016, 19.99, PlatformType.Virtualboy, true));
            videoGames.Add(new VideoGame("Crash Bandicoot", 50017, 39.99, PlatformType.Playstation, false));
            videoGames.Add(new VideoGame("The Legend of Zelda: Breath of The Wild", 50018, 59.99, PlatformType.Gamecube, false));

            return videoGames;
        }

        static void DisplayList(List<VideoGame> videoGames)
        {
            foreach (VideoGame game in videoGames)
            {
                Console.WriteLine(
                    "Game......." + game.Name +
                    "\nId........." + game.Id +
                    "\nConsole...." + game.Platform +
                    "\nVR Support." + game.VirtualReality +
                    "\nPrice......$" + game.Price +
                    "\n");
            }
        }
    }
}

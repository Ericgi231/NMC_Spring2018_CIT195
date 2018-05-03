using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureInfotionary
{
    class Program
    {
        public enum Coin
        {
            Gold,
            Silver,
            Copper,
            Diamond,
            Platinum
        }

        class TreasureItem
        {
            public Coin Name { get; set; }
            public int Count { get; set; }

        }

        static void Main(string[] args)
        {
            Dictionary<Coin, int> treasureInfo = new Dictionary<Coin, int>();
            treasureInfo.Add(Coin.Diamond, 100);
            treasureInfo.Add(Coin.Platinum, 50);
            treasureInfo.Add(Coin.Gold,10);
            treasureInfo.Add(Coin.Silver,5);
            treasureInfo.Add(Coin.Copper,1);

            List<TreasureItem> wallet = InitializeTreasure();
            int totalValue = 0;

            Console.WriteLine("Coin".PadRight(11,'.')+"Value");
            foreach (KeyValuePair<Coin, int> coin in treasureInfo)
            {
                Console.WriteLine($"{coin.Key.ToString().PadRight(11, '.')}${coin.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Coin".PadRight(11, '.') + "Count");
            foreach (TreasureItem coin in wallet)
            {
                Console.WriteLine($"{coin.Name.ToString().PadRight(11,'.')}{coin.Count}");
            }
            Console.WriteLine();

            foreach (TreasureItem coin in wallet)
            {
                totalValue += treasureInfo[coin.Name] * coin.Count;
            }
            Console.WriteLine("Total".PadRight(11, '.') + "$" + totalValue);
            Console.WriteLine();

            Console.ReadKey();
        }

        static List<TreasureItem> InitializeTreasure()
        {
            List<TreasureItem> treasure = new List<TreasureItem>()
            {
                new TreasureItem()
                {
                    Name = Coin.Gold,
                    Count = 4
                },

                new TreasureItem()
                {
                    Name = Coin.Silver,
                    Count = 6
                },

                new TreasureItem()
                {
                    Name = Coin.Diamond,
                    Count = 2
                }
            };

            return treasure;
        }
    }
}

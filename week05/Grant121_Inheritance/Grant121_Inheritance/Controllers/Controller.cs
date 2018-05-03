using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_Inheritance
{
    class Controller
    {
        #region cons
        public Controller()
        {
            Monster monster = new Monster()
            {
                Id = "skelwar1",
                Location = new int[3] { 12, 12, 12 },
                Name = "Maximus",
                MaxHp = 20,
                Hp = 20,
                Inventory = new List<GameElement> { },
                Type = "Skeleton Warrior",
                Damage = 3
            };

            Merchant merchant = new Merchant()
            {
                Id = "merch1",
                Location = new int[3] { 14, 23, 12 },
                Name = "Lars",
                MaxHp = 20,
                Hp = 20,
                Inventory = new List<GameElement> { },
                ShopInventory = new List<GameElement> { },
                ShopName = "Lars Mars Bars Imporium"
            };

            Console.WriteLine(monster.Greetings());
            Console.WriteLine(merchant.Greetings());

            Console.ReadKey();
        }

        #endregion
    }
}

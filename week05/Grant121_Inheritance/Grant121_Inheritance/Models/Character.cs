using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_Inheritance
{
    abstract class Character : GameElement
    {
        #region enums

        #endregion

        #region fields
        private int _maxHp;
        private int _hp;
        private string _name;
        private List<GameElement> _inventory;

        #endregion

        #region props
        public int MaxHp
        {
            get { return _maxHp; }
            set { _maxHp = value; }
        }

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<GameElement> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        #endregion

        #region cons

        #endregion

        #region methods

        public virtual string Greetings()
        {
            return $"Hello, my name is {_name}.";
        }

        public abstract string Defend();

        #endregion
    }
}

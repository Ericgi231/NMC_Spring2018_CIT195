using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_Inheritance
{
    class Merchant : Character
    {
        #region enums

        #endregion

        #region fields
        private string _shopName;
        private List<GameElement> _shopInventory;

        #endregion

        #region props
        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        public List<GameElement> ShopInventory
        {
            get { return _shopInventory; }
            set { _shopInventory = value; }
        }

        #endregion

        #region constructors

        #endregion

        #region overrides
        public override string Greetings()
        {
            return $"Good day, i'm {base.Name}, weclome to {_shopName}.";
            throw new NotImplementedException();
        }

        public override string Defend()
        {
            return $"Oh no.";
        }
        #endregion

        #region methods

        #endregion
    }
}

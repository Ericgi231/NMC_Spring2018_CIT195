using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_Inheritance
{
    class Monster : Character
    {
        #region enums

        #endregion

        #region fields
        private string _type;
        private int _damage;

        #endregion

        #region props

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        #endregion

        #region constructors


        #endregion

        #region override
        public override string Greetings()
        {
            return $"Sup, i'm {base.Name} the {_type}.";
            throw new NotImplementedException();
        }

        public override string Defend()
        {
            return $"Yo why you do that.";
        }
        #endregion

        #region methods

        #endregion
    }
}

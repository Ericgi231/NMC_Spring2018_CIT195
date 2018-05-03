using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grant121_QuickCode_Polymorphism
{
    class Fish : Animal
    {
        #region fields
        private string _primarySea;

        #endregion

        #region properties
        public string PrimarySea
        {
            get { return _primarySea; }
            set { _primarySea = value; }
        }


        #endregion
    }
}

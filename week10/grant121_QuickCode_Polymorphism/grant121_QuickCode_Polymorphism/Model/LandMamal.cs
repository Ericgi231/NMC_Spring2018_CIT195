using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grant121_QuickCode_Polymorphism
{
    class LandMamal : Animal
    {
        #region fields
        private string _color;
        private int _numOfLegs;

        #endregion

        #region properties
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int NumOfLegs
        {
            get { return _numOfLegs; }
            set { _numOfLegs = value; }
        }

        #endregion
    }
}

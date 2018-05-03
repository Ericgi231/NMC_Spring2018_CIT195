using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grant121_QuickCode_Polymorphism
{
    class Bird : Animal
    {
        #region fields
        private bool _canFly;

        #endregion

        #region properties
        public bool CanFly
        {
            get { return _canFly; }
            set { _canFly = value; }
        }

        #endregion
    }
}

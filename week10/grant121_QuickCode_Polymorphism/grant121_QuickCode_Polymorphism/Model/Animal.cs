using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grant121_QuickCode_Polymorphism
{
    class Animal
    {
        #region fields
        private string _name;

        #endregion

        #region properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_Inheritance
{
    class GameElement
    {
        #region enums

        #endregion

        #region fields
        private string _id;
        private int[] _location;

        #endregion

        #region props
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int[] Location
        {
            get { return _location; }
            set { _location = value; }
        }

        #endregion

        #region cons

        #endregion

        #region methods

        #endregion
    }
}

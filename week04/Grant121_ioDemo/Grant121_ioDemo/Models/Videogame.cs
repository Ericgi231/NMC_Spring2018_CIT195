using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_ioDemo
{
    public class Videogame
    {
        #region enums
        public enum PlatformName
        {
            NINTENDO,
            SONY,
            MICROSOFT,
            VALVE
        }

        #endregion

        #region fields
        private int _id;
        private string _name;
        private PlatformName _platform;

        #endregion

        #region props

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public PlatformName Platform
        {
            get
            {
                return _platform;
            }
            set
            {
                _platform = value;
            }
        }

        #endregion

        #region cons

        #endregion

        #region methods

        #endregion
    }
}

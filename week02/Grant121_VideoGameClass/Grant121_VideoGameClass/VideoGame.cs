using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grant121_VideoGameClass
{
    public enum PlatformType
    {
        Switch,
        Xbox,
        Playstation,
        Jaguar,
        Gamecube,
        Virtualboy
    }

    class VideoGame
    {
        #region fields

        private string _name;
        private int _id;
        private double _price;
        private PlatformType _platform;
        private bool _virtualReality;

        #endregion

        #region properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public PlatformType Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }

        public bool VirtualReality
        {
            get { return _virtualReality; }
            set { _virtualReality = value; }
        }

        #endregion

        #region constructors

        public VideoGame()
        {

        }

        public VideoGame(string name, int id, double price, PlatformType platform, bool virtualReality)
        {
            _name = name;
            _id = id;
            _price = price;
            _platform = platform;
            _virtualReality = virtualReality;
        }

        #endregion

        #region methods

        #endregion
    }
}

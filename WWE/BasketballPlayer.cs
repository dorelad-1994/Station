using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    class BasketballPlayer
    {
        private double _height;
        private bool _onCourt;
        public BasketballPlayer(double height,bool onCourt)
        {
            _height = height;
            _onCourt = onCourt;
        }
    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE
{
    class Basketball
    {
        private int _size;

        public Basketball(int size)
        {
            _size = size;
        }

        public void ChangeSize(int size)
        {
            _size = size;
        }
    }
}
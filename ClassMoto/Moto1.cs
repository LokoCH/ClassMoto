using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoto
{
    partial class Moto
    {
        public void increaseSpeed(int count)
        {
            _curSpeed += count;
        }


        public void increaseOdometr(int count)
        {
            _odometr += count;
        }
    }
}

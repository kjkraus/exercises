using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Time
    {
        private int seconds;

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return seconds / 60;
            }
        }
    }
}

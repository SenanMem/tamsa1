using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    class Advertising
    {
        public bool[] advertising { get; set; } = new bool[2] { false, false }; //burda 0ci index premium ve ya sadedi, 
                                                                                //1ci index ise ireli cekilmis ya yoxdu
        public DateTime[] dateTime { get; set; } = new DateTime[2];
    }
}

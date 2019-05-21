using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DamageNumbers
{
    class MarioMaker : SeparateThread
    {
        protected override void ThreadFunction()
        {
            
                new Mario();
            
            
        }
    }
}

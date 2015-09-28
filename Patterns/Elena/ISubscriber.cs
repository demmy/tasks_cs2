using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Elena
{
    interface ISubscriber
    {
        void ReactOnClossing();
        void ReactOnGoodArrivedPositive();
        void ReactOnGoodArrivedNegative();
        void ReactOnGoodArrivedNull();
    }
}

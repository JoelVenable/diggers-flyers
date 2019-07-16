using System;
using System.Collections.Generic;
using System.Text;

namespace diggers_flyers.Interfaces
{
    interface IWalkable
    {
        int MaxRunSpeed { get; }
        int NumLegs { get; }


        void Walk();

        void Run();
    }
}

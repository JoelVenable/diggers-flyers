using System;
using System.Collections.Generic;
using System.Text;

namespace diggers_flyers.Interfaces
{
    interface IFlyable
    {
        int Wingspan { get; }

        void Fly();
    }
}

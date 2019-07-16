using System;
using System.Collections.Generic;
using System.Text;

namespace diggers_flyers.Interfaces
{
    interface ISwimmable
    {
        void Swim();
        int MaxDepth { get; }
    }
}

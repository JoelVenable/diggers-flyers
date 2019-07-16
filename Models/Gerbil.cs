using System;
using System.Collections.Generic;
using System.Text;

using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class Gerbil : IWalkable
    {
        public int MaxRunSpeed { get; } = 12;

        public int NumLegs { get; } = 4;

        public void Walk()
        {
            Console.WriteLine("I'm Walkin' heah!");
        }

        public void Run()
        {
            Console.WriteLine("I'm Runnin' heah!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class Mouse : IWalkable, IDiggable
    {
        public int MaxRunSpeed { get; } = 9;

        public int NumLegs { get; } = 4;

        public void Walk()
        {
            Console.WriteLine("The mouse walks...");
        }

        public void Run()
        {
            Console.WriteLine("The mouse runs");
        }

        public void Dig()
        {
            Console.WriteLine("The mouse digs a hole");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    public class Terrapin : IWalkable, ISwimmable
    {
        public int MaxRunSpeed { get; } = 1;

        public int NumLegs { get; } = 4;

        public void Walk()
        {
            Console.WriteLine("The turtle crawls...");
        }

        public void Run()
        {
            Console.WriteLine("The turtle runs.  Can't tell the difference from his walking...");
        }

        public void Swim()
        {
            Console.WriteLine("The turtle swims gracefully");
        }

        public int MaxDepth { get; } = 40;
     }
}

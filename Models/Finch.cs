using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;


namespace diggers_flyers.Models
{
    class Finch : IFlyable
    {
        public int Wingspan { get; } = 15;

        public void Fly()
        {
            Console.WriteLine("The finch soars through the air");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class Ant : IDiggable
    {
        public void Dig()
        {
            Console.WriteLine("The ants make an anthill...");
        }
    }
}

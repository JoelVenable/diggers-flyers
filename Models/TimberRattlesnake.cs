using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class TimberRattlesnake : ISlitherable
    {
        
        public void Slither()
        {
            Console.WriteLine("The snake slithers...");
        }
     }
}

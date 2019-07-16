using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class CopperheadSnake : ISlitherable
    {
        
        public void Slither()
        {
            Console.WriteLine($"The {Length} foot long snake slithers");
        }

        public double Length { get; } = 12;

        
    }
}

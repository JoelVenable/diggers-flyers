using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;


namespace diggers_flyers.Models
{
    class CageGroup
    {
        public List<IFlyable> BirdCage { get; set; } = new List<IFlyable>() {
        new Finch(),
        new Parakeet(),
        };


        public List<ISlitherable> SnakeCage { get; set; } = new List<ISlitherable>()
        {
            new CopperheadSnake(),
            new TimberRattlesnake(),
        };

        public List<IDiggable> Crawlies { get; set; } = new List<IDiggable>()
        {
            new Ant(),
            new Earthworm(),
            new Mouse()
        };

        public List<ISwimmable> Aquarium { get; set; } = new List<ISwimmable>()
        {
            new BetaFish(),
            new Terrapin()
        };

    }
}

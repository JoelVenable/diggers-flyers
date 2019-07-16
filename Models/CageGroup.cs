using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;


namespace diggers_flyers.Models
{
    class CageGroup
    {
        public List<IFlyable> birdCage { get; set; } = new List<IFlyable>() {
        new Finch(),
        new Parakeet(),
        };


        public List<ISlitherable> snakeCage { get; set; } = new List<ISlitherable>()
        {
            new CopperheadSnake(),
            new TimberRattlesnake(),
        };

        public List<IDiggable> crawlies { get; set; } = new List<IDiggable>()
        {
            new Ant(),
            new Earthworm(),
            new Mouse()
        };

        public List<ISwimmable> aquarium { get; set; } = new List<ISwimmable>()
        {
            new BetaFish(),
            new Terrapin()
        };

    }
}

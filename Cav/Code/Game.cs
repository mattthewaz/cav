using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{

    public class Game
    {
        public Game(List<SeatName> gameSeats)
        {
            gameSeats.ForEach(seatName => Seats[seatName] = new Seat());
            MainBoard = new MainBoard(gameSeats.Count);
        }

        public MainBoard MainBoard {get;set;}
        public Dictionary<SeatName, Seat> Seats = new Dictionary<SeatName, Seat>();

        public static Dictionary<ResourceType, Resource> Resources = new Dictionary<ResourceType, Resource>() 
        {        
            {ResourceType.Wood,         new ResourceWood()},
            {ResourceType.Stone,        new ResourceStone()},
            {ResourceType.Ore,          new ResourceOre()},
            {ResourceType.Ruby,         new ResourceRuby()},
            {ResourceType.Dog,          new ResourceDog()},
            {ResourceType.Sheep,        new ResourceSheep()},
            {ResourceType.Hog,          new ResourceHog()},
            {ResourceType.Donkey,       new ResourceDonkey()},
            {ResourceType.Cow,          new ResourceCow()},
            {ResourceType.Grain,        new ResourceGrain()},
            {ResourceType.Vegetable,    new ResourceVegetable()},
            {ResourceType.Food,         new ResourceFood()},
            {ResourceType.Gold,         new ResourceGold()}
        };
    }
}
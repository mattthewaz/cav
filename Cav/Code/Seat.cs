using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public class Seat
    {
        public PlayerBoard Board = new PlayerBoard();
        public ResourceBank Resources = new ResourceBank();
    }

    public enum SeatName
    {
        Yellow,
        Red,
        Blue,
        Green,
        Purple,
        Teal,
        White
    }
}
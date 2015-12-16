using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cav.Code.Spaces;

namespace Cav.Code
{
    public class MainBoard
    {
        public MainBoard(int numPlayers)
        { 

        }

        public List<ActionSpace> Actions = new List<ActionSpace>();

        public static List<ActionSpaceType> BoardA1 = new List<ActionSpaceType>()
        {
            ActionSpaceType.DriftMining1,
            ActionSpaceType.Logging1,
            ActionSpaceType.WoodGathering1,
            ActionSpaceType.Excavation1,
            ActionSpaceType.Supplies1,
            ActionSpaceType.Clearing1,
            ActionSpaceType.StartingPlayer1,
            ActionSpaceType.OreMining1,
            ActionSpaceType.Sustenance1
        };

        public static List<ActionSpaceType> BoardA2 = new List<ActionSpaceType>()
        {
            ActionSpaceType.DriftMining4,
            ActionSpaceType.Imitation4,
            ActionSpaceType.Logging4,
            ActionSpaceType.ForestExploration4,
            ActionSpaceType.Excavation4,
            ActionSpaceType.Growth4,
            ActionSpaceType.Clearing4,
            ActionSpaceType.StartingPlayer4,
            ActionSpaceType.OreMining4,
            ActionSpaceType.Sustenance4
        };

        public static List<ActionSpaceType> BoardB = new List<ActionSpaceType>()
        {
            ActionSpaceType.RubyMining,
            ActionSpaceType.Housework,
            ActionSpaceType.SlashAndBurn
        };

        public static List<ActionSpaceType> BoardC1 = new List<ActionSpaceType>()
        {
            ActionSpaceType.StripMining3,
            ActionSpaceType.Imitation3,
            ActionSpaceType.ForestExploration3
        };

        public static List<ActionSpaceType> BoardC2 = new List<ActionSpaceType>()
        {
            ActionSpaceType.LargeDepot7,
            ActionSpaceType.Imitation7,
            ActionSpaceType.Extension7
        };

        public static List<ActionSpaceType> BoardD1 = new List<ActionSpaceType>()
        {
            ActionSpaceType.Depot5,
            ActionSpaceType.WeeklyMarket5,
            ActionSpaceType.HardwareRental5,
            ActionSpaceType.SmallScaleDriftMining5,
            ActionSpaceType.Imitation3,
            ActionSpaceType.FenceBuilding5
        };

        public static List<ActionSpaceType> BoardD2 = new List<ActionSpaceType>()
        {
            ActionSpaceType.Depot5,
            ActionSpaceType.WeeklyMarket5,
            ActionSpaceType.HardwareRental6,
            ActionSpaceType.DriftMining1,
            ActionSpaceType.Imitation6,
            ActionSpaceType.FenceBuilding6
        };
    }
}
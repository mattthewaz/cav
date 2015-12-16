using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code.Spaces
{
    public abstract class ActionSpace
    {
        public ResourceBank StoredResource = new ResourceBank();
        public ResourceBank InitialResources = new ResourceBank();
        public ResourceBank AccumulatedResources = new ResourceBank();

        public List<GameActionType> Actions = new List<GameActionType>() { };

        public virtual void Accumulate()
        {
            if (StoredResource.Resources.Count == 0)
            {
                StoredResource = InitialResources;
            }
            else
            {
                StoredResource = StoredResource + InitialResources;
            }
        }

        public static Dictionary<ActionSpaceType, ActionSpace> ActionSpaces = new Dictionary<ActionSpaceType, ActionSpace>() 
        {            
            {ActionSpaceType.DriftMining1,         new DriftMining1()},
            {ActionSpaceType.DriftMining4,         new DriftMining4()},
        };
    }

    public enum ActionSpaceType
    {
        DriftMining1,
        DriftMining4,
        Excavation1,
        Excavation4,
        StartingPlayer1,
        StartingPlayer4,
        Logging1,
        Logging4,
        OreMining1,
        OreMining4,
        Clearing1,
        Clearing4,
        Sustenance1,
        Sustenance4,

        RubyMining,
        Housework,
        SlashAndBurn,

        WoodGathering1,
        Supplies1,
        StripMining3,
        ForestExploration3,
        ForestExploration4,
        Imitation3,
        Imitation4,
        Imitation6,
        Imitation7,

        Growth4,

        Depot5,
        SmallScaleDriftMining5,
        WeeklyMarket5,
        HardwareRental5,
        HardwareRental6,
        FenceBuilding5,
        FenceBuilding6,
                
        LargeDepot7,
        Extension7,

        BlackSmithing,
        SheepFarmining,
        OreMineConstruction,
        WishForChildren,
        UrgentWishForChildren,
        DonkeyFarming,
        RubyMineConstruction,
        FamilyLife,
        Exploration,
        OreDelivery,
        Adventure,
        OreTrading,
        RubyDelivery
    }
}
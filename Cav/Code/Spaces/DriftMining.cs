using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code.Spaces
{
    public class DriftMining : ActionSpace
    {
        public new List<GameActionType> Actions = new List<GameActionType>()
        {
            GameActionType.AddTunnelCavernTile
        };
    }

    public class DriftMining1 : DriftMining
    {
        public new ResourceBank InitialResources = new ResourceBank(new Pile(ResourceType.Stone, 1));
        public new ResourceBank AccumulatedResources = new ResourceBank(new Pile(ResourceType.Stone, 1));
    }

    public class DriftMining4 : DriftMining
    {
        public new ResourceBank InitialResources = new ResourceBank(new Pile(ResourceType.Stone, 2));
        public new ResourceBank AccumulatedResources = new ResourceBank(new Pile(ResourceType.Stone, 2));
    }
}
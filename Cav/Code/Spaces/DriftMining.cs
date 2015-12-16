using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code.Spaces
{
    public class DriftMining : ActionSpace
    {
        public new ActionList Actions = new ActionList()
        {
            Actions = new List<ActionListItem>() { new ActionListItem() { Action = GameActionType.AddTunnelCavernTile } },
            Type = ActionListType.AndOr
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
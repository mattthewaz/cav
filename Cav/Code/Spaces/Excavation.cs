using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code.Spaces
{
    public class Excavation : ActionSpace
    {
        public new ActionList Actions = new ActionList()
        {
            Actions = new List<ActionListItem>() { new ActionListItem() { ActionList = new ActionList(){
                    Actions = new List<ActionListItem>(){ 
                        new ActionListItem () { Action = GameActionType.AddTunnelCavernTile}, 
                        new ActionListItem () { Action = GameActionType.AddCavernCavernTile} 
                    },
                    Type = ActionListType.EitherOr
                } } 
            },
            Type = ActionListType.AndOr
        };
    }

    public class Excavation1 : Excavation
    {
        public new ResourceBank InitialResources = new ResourceBank(new Pile(ResourceType.Stone, 1));
        public new ResourceBank AccumulatedResources = new ResourceBank(new Pile(ResourceType.Stone, 1));
    }

    public class Excavation4 : Excavation
    {
        public new ResourceBank InitialResources = new ResourceBank(new Pile(ResourceType.Stone, 2));
        public new ResourceBank AccumulatedResources = new ResourceBank(new Pile(ResourceType.Stone, 1));
    }
}
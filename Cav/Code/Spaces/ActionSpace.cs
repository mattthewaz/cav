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
        DriftMining4
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code.Spaces
{
    public delegate void Action(Seat actor);

    public abstract class ActionSpace
    {

        public ResourceBank StoredResource;
        public List<Action> Actions;

        public ResourceBank InitialResources;
        public ResourceBank AccumulatedResources;

        public void Accumulate()
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
    }
}
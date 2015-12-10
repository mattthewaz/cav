using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cav.Code;

namespace Cav
{
    /// <summary>
    /// Summary description for TestHandler
    /// </summary>
    public class TestHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var allTestsPass = true;

            context.Response.ContentType = "text/plain";

            allTestsPass &= AddPileToResourceBank();
            allTestsPass &= TallyScorableResources();

            context.Response.Write(allTestsPass);
        }

        public bool AddPileToResourceBank()
        {
            var bank1 = new ResourceBank();
            var pileOfSheep = new Pile(ResourceType.Sheep, 10);
            var pileOfRubies = new Pile(ResourceType.Ruby, 5);

            var bank2 = bank1 + pileOfSheep + pileOfRubies;

            if (bank2.Resources.Count != 2)
                return false;

            return true;
        }

        public bool TallyScorableResources()
        {
            var scoreables = new List<Scoreable>();

            var sheep = new Pile(ResourceType.Sheep, 10);
            var dogs = new Pile(ResourceType.Dog, 5);
            var rubies = new Pile(ResourceType.Ruby, 3);
            var hogs = new Pile(ResourceType.Hog, 2);
            var donkeys = new Pile(ResourceType.Donkey, 3);
            var cows = new Pile(ResourceType.Cow, 1);
            var grain = new Pile(ResourceType.Grain, 3);
            var veggies = new Pile(ResourceType.Vegetable, 2);
            var gold = new Pile(ResourceType.Gold, 4);

            var bank = sheep + dogs + rubies + hogs + donkeys + cows + grain + veggies + gold;

            if (bank.GetPointValue() != 32)
                return false;

            return true;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
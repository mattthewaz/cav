using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public class ResourceBank : Scoreable
    {
        public ResourceBank()
        {
            Resources = new Dictionary<ResourceType, int>();
        }

        public ResourceBank(Dictionary<ResourceType, int> items) 
        {
            if (items == null)
            {
                Resources = new Dictionary<ResourceType, int>();
            }
            else
            {
                Resources = items;
            }
        }

        public ResourceBank(Pile pile)
        {
            Resources = new Dictionary<ResourceType, int>() { { pile.Type, pile.Amount } };
        }

        public Dictionary<ResourceType, int> Resources;

        public static ResourceBank operator + (ResourceBank bank1, ResourceBank bank2)
        {
            var resourceTypes = bank1.Resources.Keys.Union(bank2.Resources.Keys);
            var newPiles = new Dictionary<ResourceType, int>();

            foreach (var resourceType in resourceTypes)
            {
                int pile1, pile2;
                bank1.Resources.TryGetValue(resourceType, out pile1);
                bank2.Resources.TryGetValue(resourceType, out pile2);
                newPiles[resourceType] = pile1 + pile2;
            }

            return new ResourceBank(newPiles);
        }

        public static ResourceBank operator +(ResourceBank bank, Pile pileToAdd)
        {
            var newPiles = new Dictionary<ResourceType, int>();
            foreach (var pile in bank.Resources)
            {
                newPiles[pile.Key] = pile.Value;
            }

            int pileAddingTo;
            bank.Resources.TryGetValue(pileToAdd.Type, out pileAddingTo);
            newPiles[pileToAdd.Type] = pileAddingTo + pileToAdd.Amount; 

            return new ResourceBank(newPiles);
        }

        public static ResourceBank operator -(ResourceBank bank1, ResourceBank bank2)
        {
            var resourceTypes = bank1.Resources.Keys.Union(bank2.Resources.Keys);
            var newPiles = new Dictionary<ResourceType, int>();

            foreach (var resourceType in resourceTypes)
            {
                int pile1, pile2;
                bank1.Resources.TryGetValue(resourceType, out pile1);
                bank2.Resources.TryGetValue(resourceType, out pile2);
                var newAmount = pile1 - pile2;
                newPiles[resourceType] = newAmount < 0 ? 0 : newAmount;
            }

            return new ResourceBank(newPiles);
        }

        public static ResourceBank operator -(ResourceBank bank, Pile pileToRemove)
        {          
            var newPiles = new Dictionary<ResourceType, int>();
            foreach (var pile in bank.Resources)
            {
                var newAmount = pile.Value - pileToRemove.Type == pile.Key ? pileToRemove.Amount : 0;
                newPiles[pile.Key] = newAmount < 0 ? 0 : newAmount;
            }

            return new ResourceBank(newPiles);
        }

        public int GetPointValue()
        {
            var score = 0;

            foreach (var pile in Resources)
            {
                score += Game.Resources[pile.Key].GetPointValue(pile.Value);
            }

            return score;
        }
    }

    public class Pile : Scoreable
    {
        public Pile(ResourceType type, int amount)
        {
            Type = type;
            Amount = amount;
        }

        public static ResourceBank operator +(Pile pile1, Pile pile2)
        {
            var newPiles = new Dictionary<ResourceType, int>();

            newPiles[pile1.Type] = pile1.Amount;
            newPiles[pile2.Type] = pile2.Amount;

            return new ResourceBank(newPiles);
        }

        public int GetPointValue()
        {
            return Game.Resources[Type].GetPointValue(Amount);
        }

        public ResourceType Type { get; set; }
        public int Amount { get; set; }
    }
}
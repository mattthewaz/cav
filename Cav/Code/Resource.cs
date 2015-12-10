using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public interface Resource
    {
        ResourceType Type { get; }
        bool IsAnimal { get; }
        bool IsFarmAnimal { get; }
        int GetFoodValue (int num);
        int GetPointValue(int num);
    }

    public enum ResourceType 
    {
        Wood,
        Stone,
        Ore,
        Ruby,
        Dog,
        Sheep,
        Hog,
        Donkey,
        Cow,
        Grain,
        Vegetable,
        Food,
        Gold
    }

    public class ResourceWood : Resource
    {
        public ResourceType Type { get { return ResourceType.Wood; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return 0; }
        public int GetPointValue(int num) { return 0; }
    }

    public class ResourceStone : Resource
    {
        public ResourceType Type { get { return ResourceType.Stone; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return 0; }
        public int GetPointValue(int num) { return 0; }
    }

    public class ResourceOre : Resource
    {
        public ResourceType Type { get { return ResourceType.Ore; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return 0; }
        public int GetPointValue(int num) { return 0; }
    }

    public class ResourceRuby : Resource
    {
        public ResourceType Type { get { return ResourceType.Ruby; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return num * 2; }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceDog : Resource
    {
        public ResourceType Type { get { return ResourceType.Dog; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return 0; }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceSheep : Resource
    {
        public ResourceType Type { get { return ResourceType.Sheep; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return true; } }
        public int GetFoodValue(int num) { return num; }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceHog : Resource
    {
        public ResourceType Type { get { return ResourceType.Hog; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return true; } }
        public int GetFoodValue(int num) { return num * 2; }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceDonkey : Resource
    {
        public ResourceType Type { get { return ResourceType.Donkey; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return true; } }
        public int GetFoodValue(int num) { return (int)(num * 1.5); }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceCow : Resource
    {
        public ResourceType Type { get { return ResourceType.Cow; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return true; } }
        public int GetFoodValue(int num) { return (int)(num * 3); }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceGrain : Resource
    {
        public ResourceType Type { get { return ResourceType.Grain; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return (int)(num * 1); }
        public int GetPointValue(int num) { return (int)((1 + num / 2)); }
    }

    public class ResourceVegetable : Resource
    {
        public ResourceType Type { get { return ResourceType.Vegetable; } }
        public bool IsAnimal { get { return true; } }
        public bool IsFarmAnimal { get { return true; } }
        public int GetFoodValue(int num) { return (int)(num * 2); }
        public int GetPointValue(int num) { return num; }
    }

    public class ResourceFood : Resource
    {
        public ResourceType Type { get { return ResourceType.Food; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return (int)(num * 1); }
        public int GetPointValue(int num) { return 0; }
    }

    public class ResourceGold : Resource
    {
        public ResourceType Type { get { return ResourceType.Gold; } }
        public bool IsAnimal { get { return false; } }
        public bool IsFarmAnimal { get { return false; } }
        public int GetFoodValue(int num) { return (int)(num - 1); }
        public int GetPointValue(int num) { return num; }
    }
}
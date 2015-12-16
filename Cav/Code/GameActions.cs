using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public delegate void GameAction(Game game, SeatName actor);

    public enum GameActionType
    {
        None,

        AddTunnelCavernTile,
        AddCavernCavernTile
    }
    
    public static class GameActions
    {
        public static Dictionary<GameActionType, GameAction> ActionMap = new Dictionary<GameActionType, GameAction>()
        {
            {GameActionType.AddTunnelCavernTile, PromptTunnelCavernTile},            
            {GameActionType.AddCavernCavernTile, PromptCavernCavernTile}
        };

        public static void PromptTunnelCavernTile(Game game, SeatName actor)
        {

        }

        public static void PromptCavernCavernTile(Game game, SeatName actor)
        {

        }
    }
}
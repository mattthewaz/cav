using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public class Match
    {
        public Match(Player matchHost)
        {
            SeatPlayer(matchHost);
        }

        /// <summary>
        /// Start the match.
        /// </summary>
        /// <returns>Returns true if successful.</returns>
        public bool StartMatch()
        {
            if (Players.Count == 0 || Players.Count > 7)
                return false;

            Game = new Game(Players.Keys.ToList());
            return true;
        }

        # region Seat Management
        public Dictionary<SeatName, Player> Players = new Dictionary<SeatName, Player>();

        public static List<SeatName> SeatList = new List<SeatName>() { SeatName.Yellow, SeatName.Red, SeatName.Blue, SeatName.Green, SeatName.Purple, SeatName.Teal, SeatName.White };

        /// <summary>
        /// Registers a player at the first available seat.
        /// </summary>
        /// <param name="playerRequesting">The player to be seated.</param>
        /// <param name="force">If true, any existing player at that seat will be replaced.</param>
        /// <returns>Returns true if successful.</returns>
        public bool SeatPlayer(Player playerRequesting, bool force = false)
        {
            var seatRequested = SeatList.FirstOrDefault(seat => !Players.Keys.Contains(seat));

            return SeatPlayer(seatRequested, playerRequesting, force);
        }

        /// <summary>
        /// Registers a player at a specific seat. Returns true if succesful.
        /// </summary>
        /// <param name="seatRequested">Which specific seat has been requested by the player.</param>
        /// <param name="playerRequesting">The player to be seated.</param>
        /// <param name="force">If true, any existing player at that seat will be replaced.</param>
        /// <returns>Returns true if successful.</returns>
        public bool SeatPlayer(SeatName seatRequested, Player playerRequesting, bool force = false)
        {
            if (Players[seatRequested] == null || force)
            {
                //Remove the player from any other seat he's taken
                UnseatPlayer(playerRequesting);

                Players[seatRequested] = playerRequesting;
            }
            else 
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Given a player, removes that player from its current seat
        /// </summary>
        /// <param name="playerToRemove"></param>
        public void UnseatPlayer(Player playerToRemove)
        {
            var playerSeat = Players.FirstOrDefault(seat => seat.Value == playerToRemove);
            if (playerSeat.Value == playerToRemove)
            {
                Players.Remove(playerSeat.Key);
            }
        }

        /// <summary>
        /// Given a seat, removes any player from the seat
        /// </summary>
        /// <param name="seatToEmpty"></param>
        public void EmptySeat(SeatName seatToEmpty)
        {
            Players.Remove(seatToEmpty);
        }
        # endregion

        public Game Game { get; set; }
    }
}
using Exiled.API.Features;
using System.Linq;

namespace XingYeAPI.Extensions.Player_Extensions
{
    public static class Spectating
    {
        /// <summary>
        /// 获取当前玩家正在观看的玩家
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static Player GetWatchingPlayer(this Player player)
        {
            Player WatchingPlayer = null;

            foreach (Player player1 in Player.List)
            {
                if (player1 == player) continue;

                if (player1.CurrentSpectatingPlayers.Contains(player))
                {
                    WatchingPlayer = player1;
                    break;
                }
            }

            return WatchingPlayer;
        }
    }
}

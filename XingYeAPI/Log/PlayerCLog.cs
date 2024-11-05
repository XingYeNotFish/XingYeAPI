using Exiled.API.Features;
using XingYeAPI.Enums;

namespace XingYeAPI.Log
{
    public static class PlayerCLog
    {
        /// <summary>
        /// 给玩家发送一个带等级的Log信息
        /// </summary>
        /// <param name="player"></param>
        /// <param name="message"></param>
        /// <param name="LevelType"></param>
        public static void SendLog(this Player player, string message, XingYeLogLevelType LevelType = XingYeLogLevelType.Info)
        {
            string log = "";
            string color = Color(LevelType);
            switch (LevelType)
            {
                case XingYeLogLevelType.Debug:
                    log = $"<color={color}>[调试]</color> {message}";
                    break;
                case XingYeLogLevelType.Info:
                    log = $"<color={color}>[信息]</color> {message}";
                    break;
                case XingYeLogLevelType.Warning:
                    log = $"<color={color}>[警告]</color> {message}";
                    break;
                case XingYeLogLevelType.Error:
                    log = $"<color={color}>[错误]</color> {message}";
                    break;
                case XingYeLogLevelType.Fatal:
                    log = $"<color={color}>[致命错误]</color> {message}";
                    break;
                default:
                    break;
            }
            player.SendConsoleMessage(log,color);
        }

        private static string Color(XingYeLogLevelType LevelType)
        {
            switch (LevelType)
            {
                case XingYeLogLevelType.Debug:
                    return "#00FF00";
                case XingYeLogLevelType.Info:
                    return "#00FFFF";
                case XingYeLogLevelType.Warning:
                    return "#FFA500";
                case XingYeLogLevelType.Error:
                    return "#FF0000";
                case XingYeLogLevelType.Fatal:
                    return "#A020F0";
                default:
                    return "";
            }
        }
    }
}

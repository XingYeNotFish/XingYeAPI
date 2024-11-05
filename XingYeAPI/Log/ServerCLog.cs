using XingYeAPI.Enums;

namespace XingYeAPI.Log
{
    public static class ServerCLog
    {
        /// <summary>
        /// 向服务器后台发送一个带等级的Log信息
        /// </summary>
        /// <param name="message"></param>
        /// <param name="LevelType"></param>
        public static void SendLog(string message, XingYeLogLevelType LevelType = XingYeLogLevelType.Info)
        {
            switch (LevelType)
            {
                case XingYeLogLevelType.Debug:
                    ServerConsole.AddLog(message, System.ConsoleColor.Green);
                    break;
                case XingYeLogLevelType.Info:
                    ServerConsole.AddLog(message, System.ConsoleColor.Cyan);
                    break;
                case XingYeLogLevelType.Warning:
                    ServerConsole.AddLog(message, System.ConsoleColor.DarkYellow);
                    break;
                case XingYeLogLevelType.Error:
                    ServerConsole.AddLog(message, System.ConsoleColor.Red);
                    break;
                case XingYeLogLevelType.Fatal:
                    ServerConsole.AddLog(message, System.ConsoleColor.DarkRed);
                    break;
                default:
                    break;
            }
        }
    }
}

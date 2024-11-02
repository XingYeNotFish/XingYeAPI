using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using System.Linq;

namespace XingYeAPI.Extensions.Player_Extensions
{
    public static class CustomRoles
    {
        /// <summary>
        /// 判断玩家是否为自定义角色 <code>仅支持CustomRoles的角色!</code>
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsCustomRole(this Player player)
        {
            var CustomRoles = CustomRole.Registered.Where(customrole => customrole.Check(player));
            if (CustomRoles.Any())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取玩家的自定义角色 <code>仅支持CustomRoles的角色!</code>
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static CustomRole GetCustomRole(this Player player)
        {
            if (!player.IsCustomRole())
            {
                return null;
            }

            var CustomRoles = CustomRole.Registered.Where(customrole => customrole.Check(player));
            var currentcustomrole = CustomRoles.First();

            return currentcustomrole;
        }
    }
}

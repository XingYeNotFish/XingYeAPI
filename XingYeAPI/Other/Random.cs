using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;
using System.Linq;
using XingYeAPI.Extensions.Player_Extensions;

namespace XingYeAPI.Other
{
    public static class Random
    {
        // >===================== 随机数相关 =====================< \\

        /// <summary>
        /// 这将返回一个0-1之间的 double 随机数
        /// </summary>
        /// <returns></returns>
        public static double RandomNum()
        {
            System.Random random = new System.Random();
            double num = random.NextDouble();

            return num;
        }

        // >===================== 随机数相关 =====================< \\

        // >===================== 随机刷新相关 =====================< \\

        public enum XingYeSpawnType : sbyte
        {
            None = -1,
            FromClassD,
            FromScientist,
            FromFacilityGuard,
            FromSpectator,
        }

        /// <summary>
        /// 随机从预定的角色列表中随机分配自定义角色 <code>仅支持CustomRoles的角色!</code>
        /// </summary>
        /// <param name="roleid"></param>
        /// <param name="spawntype"></param>
        public static void RandomSpawnSR(uint roleid, XingYeSpawnType spawntype = XingYeSpawnType.FromSpectator)
        {
            List<Player> cds = Player.Get(RoleTypeId.ClassD).ToList().Where(p => !p.IsCustomRole()).ToList();
            List<Player> scs = Player.Get(RoleTypeId.Scientist).ToList().Where(p => !p.IsCustomRole()).ToList();
            List<Player> fgs = Player.Get(RoleTypeId.FacilityGuard).ToList().Where(p => !p.IsCustomRole()).ToList();
            List<Player> sps = Player.Get(RoleTypeId.Spectator).ToList().Where(p => !p.IsCustomRole()).ToList();

            switch (spawntype)
            {
                case XingYeSpawnType.FromClassD:
                    Player p = cds[UnityEngine.Random.Range(0, cds.Count)];
                    CustomRole.Get(roleid).AddRole(p);
                    break;
                case XingYeSpawnType.FromScientist:
                    Player p1 = scs[UnityEngine.Random.Range(0, scs.Count)];
                    CustomRole.Get(roleid).AddRole(p1);
                    break;
                case XingYeSpawnType.FromFacilityGuard:
                    Player p2 = fgs[UnityEngine.Random.Range(0, fgs.Count)];
                    CustomRole.Get(roleid).AddRole(p2);
                    break;
                case XingYeSpawnType.FromSpectator:
                    Player p3 = sps[UnityEngine.Random.Range(0, sps.Count)];
                    CustomRole.Get(roleid).AddRole(p3);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 随机从指定角色列表中随机分配自定义角色 <code>仅支持CustomRoles的角色!</code>
        /// </summary>
        /// <param name="roleid"></param>
        /// <param name="players"></param>
        public static void RandomSpawnSR(uint roleid, List<Player> players)
        {
            Player p = players[UnityEngine.Random.Range(0, players.Count)];
            CustomRole.Get(roleid).AddRole(p);
            players.Remove(p);
        }

        // >===================== 随机刷新相关 =====================< \\
    }
}

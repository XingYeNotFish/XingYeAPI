using PlayerRoles;

namespace XingYeAPI.Extensions.RoleTypeId_Extensions
{
    public static class Translated
    {
        /// <summary>
        /// 获取RoleTypeId的中文翻译
        /// </summary>
        /// <param name="roleTypeId"></param>
        /// <returns>
        ///     <code>RoleTypeId.FacilityGuard -> 设施警卫</code>
        ///     <code>RoleTypeId.ClassD -> D级人员</code>
        ///     <code>RoleTypeId.Scisist -> 科学家</code>
        ///     <code>...</code>
        /// </returns>
        public static string GetTranslated(this RoleTypeId roleTypeId)
        {
            string result;
            switch (roleTypeId)
            {
                case RoleTypeId.ChaosConscript:
                    result = "混沌征召兵";
                    goto IL_70;
                case RoleTypeId.ChaosMarauder:
                    result = "混沌掠夺者";
                    goto IL_70;
                case RoleTypeId.ChaosRepressor:
                    result = "混沌压制者";
                    goto IL_70;
                case RoleTypeId.ChaosRifleman:
                    result = "混沌步枪兵";
                    goto IL_70;
                case RoleTypeId.ClassD:
                    result = "D级人员";
                    goto IL_70;
                case RoleTypeId.FacilityGuard:
                    result = "设施警卫";
                    goto IL_70;
                case RoleTypeId.Filmmaker:
                    result = "导演模式";
                    goto IL_70;
                case RoleTypeId.NtfCaptain:
                    result = "九尾狐-指挥官";
                    goto IL_70;
                case RoleTypeId.NtfPrivate:
                    result = "九尾狐-列兵";
                    goto IL_70;
                case RoleTypeId.NtfSergeant:
                    result = "九尾狐-中士";
                    goto IL_70;
                case RoleTypeId.NtfSpecialist:
                    result = "九尾狐-收容专家";
                    goto IL_70;
                case RoleTypeId.Overwatch:
                    result = "监管模式";
                    goto IL_70;
                case RoleTypeId.Scientist:
                    result = "科学家";
                    goto IL_70;
                case RoleTypeId.Scp049:
                    result = "SCP-049";
                    goto IL_70;
                case RoleTypeId.Scp0492:
                    result = "SCP-049-2";
                    goto IL_70;
                case RoleTypeId.Scp079:
                    result = "SCP-079";
                    goto IL_70;
                case RoleTypeId.Scp096:
                    result = "SCP-096";
                    goto IL_70;
                case RoleTypeId.Scp106:
                    result = "SCP-106";
                    goto IL_70;
                case RoleTypeId.Scp173:
                    result = "SCP-173";
                    goto IL_70;
                case RoleTypeId.Scp3114:
                    result = "SCP-3114";
                    goto IL_70;
                case RoleTypeId.Scp939:
                    result = "SCP-939";
                    goto IL_70;
                case RoleTypeId.Spectator:
                    result = "观察者";
                    goto IL_70;
                case RoleTypeId.Tutorial:
                    result = "教程角色";
                    goto IL_70;
                case RoleTypeId.CustomRole:
                    result = "插件角色";
                    goto IL_70;
                case RoleTypeId.None:
                    result = "无";
                    goto IL_70;
            }
            result = "未知";
        IL_70:
            return result;
        }
    }
}

using Exiled.API.Enums;

namespace XingYeAPI.Extensions.RoomType_Extensions
{
    public static class Translated
    {
        /// <summary>
        /// 获取各个房间的中文名(字符串)
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns>
        ///     <code>RoomType.Unknown -> 未知</code>
        ///     <code>RoomType.LczArmory -> 轻收容区武器库</code>
        ///     <code>RoomType.LczCurve -> 轻收容区拐弯走廊</code>
        ///     <code>...</code>
        /// </returns>
        public static string GetTranslated(this RoomType roomType)
        {
            string result;
            switch (roomType)
            {
                case RoomType.Unknown:
                    result = "未知";
                    goto IL_70;
                case RoomType.LczArmory:
                    result = "轻收容区武器库";
                    goto IL_70;
                case RoomType.LczCurve:
                    result = "轻收容区拐弯走廊";
                    goto IL_70;
                case RoomType.LczStraight:
                    result = "轻收容区直行走廊";
                    goto IL_70;
                case RoomType.Lcz914:
                    result = "SCP-914收容间";
                    goto IL_70;
                case RoomType.LczCrossing:
                    result = "轻收容区十字走廊";
                    goto IL_70;
                case RoomType.LczTCross:
                    result = "轻收容区T型走廊";
                    goto IL_70;
                case RoomType.LczCafe:
                    result = "轻收容区PC-15";
                    goto IL_70;
                case RoomType.LczPlants:
                    result = "轻收容区VT-00";
                    goto IL_70;
                case RoomType.LczToilets:
                    result = "轻收容区厕所";
                    goto IL_70;
                case RoomType.LczAirlock:
                    result = "轻收容区空气闸门走廊";
                    goto IL_70;
                case RoomType.Lcz173:
                    result = "轻收容区SCP-173收容间(旧)";
                    goto IL_70;
                case RoomType.LczClassDSpawn:
                    result = "D级人员关押区";
                    goto IL_70;
                case RoomType.LczCheckpointB:
                    result = "轻收容区检查点B";
                    goto IL_70;
                case RoomType.LczGlassBox:
                    result = "轻收容区GR-18";
                    goto IL_70;
                case RoomType.LczCheckpointA:
                    result = "轻收容区检查点A";
                    goto IL_70;
                case RoomType.Hcz079:
                    result = "重收容区SCP-079收容间";
                    goto IL_70;
                case RoomType.HczEzCheckpointA:
                    result = "重收容区检查点A";
                    goto IL_70;
                case RoomType.HczEzCheckpointB:
                    result = "重收容区检查点B";
                    goto IL_70;
                case RoomType.HczArmory:
                    result = "重收容区武器库";
                    goto IL_70;
                case RoomType.Hcz939:
                    result = "重收容区SCP-939收容间";
                    goto IL_70;
                case RoomType.HczHid:
                    result = "重收容区电磁炮储存间";
                    goto IL_70;
                case RoomType.Hcz049:
                    result = "重收容区SCP-049收容间";
                    goto IL_70;
                case RoomType.HczCrossing:
                    result = "重收容区十字走廊";
                    goto IL_70;
                case RoomType.Hcz106:
                    result = "重收容区SCP-106收容间";
                    goto IL_70;
                case RoomType.HczNuke:
                    result = "重收容区核弹存放区";
                    goto IL_70;
                case RoomType.HczTesla:
                    result = "重收容区电网走廊";
                    goto IL_70;
                case RoomType.HczServers:
                    result = "重收容区机房";
                    goto IL_70;
                case RoomType.HczTCross:
                    result = "重收容区T型走廊";
                    goto IL_70;
                case RoomType.HczCurve:
                    result = "重收容区拐弯走廊";
                    goto IL_70;
                case RoomType.Hcz096:
                    result = "重收容区SCP-096收容间";
                    goto IL_70;
                case RoomType.EzVent:
                    result = "办公区红色通风区";
                    goto IL_70;
                case RoomType.EzIntercom:
                    result = "办公区广播室";
                    goto IL_70;
                case RoomType.EzGateA:
                    result = "办公区A大门";
                    goto IL_70;
                case RoomType.EzDownstairsPcs:
                    result = "办公区低地办公室";
                    goto IL_70;
                case RoomType.EzCurve:
                    result = "办公区拐弯走廊";
                    goto IL_70;
                case RoomType.EzPcs:
                    result = "办公区办公室";
                    goto IL_70;
                case RoomType.EzCrossing:
                    result = "办公区十字走廊";
                    goto IL_70;
                case RoomType.EzCollapsedTunnel:
                    result = "办公区隧道间(坍塌)";
                    goto IL_70;
                case RoomType.EzConference:
                    result = "办公区Dr.L办公室走廊";
                    goto IL_70;
                case RoomType.EzStraight:
                    result = "办公区直行走廊";
                    goto IL_70;
                case RoomType.EzCafeteria:
                    result = "办公区自助餐厅"; // emmm,这个地方好像和自助餐厅没啥关系
                    goto IL_70;
                case RoomType.EzUpstairsPcs:
                    result = "办公区高地办公室";
                    goto IL_70;
                case RoomType.EzGateB:
                    result = "办公区B大门";
                    goto IL_70;
                case RoomType.EzShelter:
                    result = "办公区避难室";
                    goto IL_70;
                case RoomType.Pocket:
                    result = "口袋空间";
                    goto IL_70;
                case RoomType.Surface:
                    result = "地表";
                    goto IL_70;
                case RoomType.HczStraight:
                    result = "重收容区直行走廊";
                    goto IL_70;
                case RoomType.EzTCross:
                    result = "办公区T型走廊";
                    goto IL_70;
                case RoomType.Lcz330:
                    result = "轻收容区SCP-330收容间";
                    goto IL_70;
                case RoomType.EzCheckpointHallway:
                    result = "办公区检查点长廊";
                    goto IL_70;
                case RoomType.HczTestRoom:
                    result = "重收容区测试间(SCP-939旧收容间)";
                    goto IL_70;
                case RoomType.HczElevatorA:
                    result = "重收容区电梯A";
                    goto IL_70;
                case RoomType.HczElevatorB:
                    result = "重收容区电梯B";
                    goto IL_70;
            }
            result = "未知";
        IL_70:
            return result;
        }
    }
}

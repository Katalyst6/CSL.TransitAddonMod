﻿
namespace Transit.Addon.Core.Extenders.PathFinding
{
    public interface ILaneSpeedManager
    {
        float GetLaneSpeedLimit(NetInfo.Lane lane, uint laneId);
    }
}
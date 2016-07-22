﻿using System;
using System.Collections.Generic;
using ColossalFramework;
using ColossalFramework.UI;

namespace Transit.Framework.Extenders.AI
{
    public class ZoneBlocksCreatorProvider : Singleton<ZoneBlocksCreatorProvider>
    {
        private readonly IDictionary<Type, IZoneBlocksCreator> _instances = new Dictionary<Type, IZoneBlocksCreator>();
        private readonly IDictionary<string, IZoneBlocksCreator> _customCreators = new Dictionary<string, IZoneBlocksCreator>(StringComparer.InvariantCultureIgnoreCase);

        public void RegisterCustomCreator<T>(string netinfoName)
            where T : IZoneBlocksCreator, new()
        {
            var creatorType = typeof (T);

            if (!_instances.ContainsKey(creatorType))
            {
                _instances[creatorType] = new T();
            }
            
            _customCreators[netinfoName] = _instances[creatorType];
        }

        public bool HasCustomCreator(string netinfoName)
        {
            return _customCreators.ContainsKey(netinfoName);
        }

        public IZoneBlocksCreator GetCustomCreator(string netinfoName)
        {
            return _customCreators[netinfoName];
        }
    }
}
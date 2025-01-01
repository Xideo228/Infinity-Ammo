using System;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Infinity_Ammo
{
    public class Config : IConfig
    {
        [Description("On / Off plugin")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug mode")]
        public bool Debug { get; set; } = false;
        [Description("Drop ammo on dead")]
        public bool DropOnDying { get; set; } = false;
        [Description("Infinite ammo for Particle Disruptor")]
        public bool AllowAmmoParticleDisruptor { get; set; } = true;
        [Description("Maximum number of ammo. Recommended: 100")]
        public int MaxAmmo { get; set; } = 100;
    }
}

using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Firearm = Exiled.API.Features.Items.Firearm;
using System;

namespace Infinity_Ammo
{
    public class EventHandler
    {

        public void OnShot(ShotEventArgs ev)
        {
            if (ev.Firearm.FirearmType == Exiled.API.Enums.FirearmType.ParticleDisruptor)
            {
                if (Plugin.plugin.Config.AllowAmmoParticleDisruptor)
                {
                    ev.Firearm.AmmoDrain = 5;
                    ev.Firearm.BarrelAmmo = 5;
                    ev.Firearm.MagazineAmmo = 5;
                    Log.Debug("The replenishment function for 5 cartridges was performed");
                }
                else return;
            }

            if (ev.Firearm.FirearmType == Exiled.API.Enums.FirearmType.Revolver)
            {
                ev.Player.SetAmmo(AmmoType.Ammo44Cal, Convert.ToUInt16(Plugin.plugin.Config.MaxAmmo));
                Log.Debug("The replenishment function for " + Plugin.plugin.Config.MaxAmmo + " cartridges was performed");
            }
            if (ev.Firearm.FirearmType != Exiled.API.Enums.FirearmType.Revolver)
            {
                ev.Player.SetAmmo(ev.Firearm.AmmoType, Convert.ToUInt16(Plugin.plugin.Config.MaxAmmo));
                Log.Debug("The replenishment function for " + Plugin.plugin.Config.MaxAmmo + " cartridges was performed");
            }
        }

        public void OnDying(DyingEventArgs ev)
        {
            if (!Plugin.plugin.Config.DropOnDying)
            {
                ev.Player.SetAmmo(AmmoType.Nato9, 0);
                ev.Player.SetAmmo(AmmoType.Ammo44Cal, 0);
                ev.Player.SetAmmo(AmmoType.Ammo12Gauge, 0);
                ev.Player.SetAmmo(AmmoType.Nato556, 0);
                ev.Player.SetAmmo(AmmoType.Nato762, 0);
                ev.Player.SetAmmo(AmmoType.None, 0);
                Log.Debug("The player is dead, the bullets removed");
            }
            else Log.Debug("The player is dead, the bullets are not removed");
        }
    }
}

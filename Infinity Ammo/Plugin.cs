using System;
using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;

namespace Infinity_Ammo
{
    public class Plugin : Plugin<Config>
    {

        public override string Name => "Infinity Ammo";
        public override string Prefix => "IA";
        public override string Author => "Hid Man";
        public override Version Version => base.Version;
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public static Plugin plugin;
        private EventHandler handler_;

        public override void OnEnabled()
        {
            plugin = this;
            handler_ = new EventHandler();

            Player.Dying += handler_.OnDying;
            Player.Shot += handler_.OnShot;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;

            Player.Dying -= handler_.OnDying;
            Player.Shot -= handler_.OnShot;
            handler_ = null;

            base.OnDisabled();
        }
    }
}

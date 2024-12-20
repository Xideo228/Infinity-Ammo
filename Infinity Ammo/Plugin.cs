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

            // Exiled.Events.Handlers.Server.RoundStarted += OnStart; // Not be Realised / Не реализованная функция
            // Exiled.Events.Handlers.Server.RespawnedTeam += OnSpawnedTeam; // Not be Realised / Не реализованная функция
            // Player.ReloadingWeapon += handler_.OnReload;
            Player.Dying += handler_.OnDying;
            Player.Shooting += handler_.OnShooting;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;

            // Exiled.Events.Handlers.Server.RoundStarted -= OnStart; Not be Realised / Не реализованная функция
            // Exiled.Events.Handlers.Server.RespawnedTeam -= OnSpawnedTeam; Not be Realised / Не реализованная функция
            // Player.ReloadingWeapon -= handler_.OnReload;
            Player.Dying -= handler_.OnDying;
            Player.Shooting -= handler_.OnShooting;
            handler_ = null;

            base.OnDisabled();
        }
    }
}

using System;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Infinity_Ammo
{
    public class Config : IConfig
    {
        [Description("Включение/Выключение плагина")]
        public bool IsEnabled { get; set; } = true;
        [Description("Расширеный вывод для консоли")]
        public bool Debug { get; set; } = false;
        [Description("Выподение патрон при смерти")]
        public bool DropOnDying { get; set; } = false;
        [Description("Максимальное количсво патрон. Рекомендовано: 100")]
        public int MaxAmmo { get; set; } = 100;
    }
}

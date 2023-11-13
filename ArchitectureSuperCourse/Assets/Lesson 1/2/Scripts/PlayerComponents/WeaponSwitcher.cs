using System;
using System.Collections.Generic;
using Lesson_1.WeaponComponents;

namespace Lesson_1.PlayerComponents
{
    public class WeaponSwitcher
    {
        private Dictionary<WeaponType, WeaponBase> _weapons;
        private WeaponBase _currentWeapon;

        public WeaponBase CurrentWeapon => _currentWeapon;

        public event Action<WeaponBase> WeaponChanged;
        
        public WeaponSwitcher(WeaponType startWeaponType, BulletsPool bulletsPool)
        {
            _weapons = new Dictionary<WeaponType, WeaponBase>()
            {
                { WeaponType.Pistol, new Pistol(bulletsPool) },
                { WeaponType.Rifle, new Rifle(bulletsPool) },
                { WeaponType.Shotgun, new Shotgun(bulletsPool) }
            };

            SwitchWeapon(startWeaponType);
        }

        public void SwitchWeapon(WeaponType type)
        {
            _currentWeapon = _weapons[type];
            WeaponChanged?.Invoke(_currentWeapon);
        }
    }
}
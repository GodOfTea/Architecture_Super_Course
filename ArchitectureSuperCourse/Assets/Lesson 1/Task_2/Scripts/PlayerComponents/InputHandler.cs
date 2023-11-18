using Lesson_1.Task_2.WeaponComponents;
using UnityEngine;

namespace Lesson_1.Task_2.PlayerComponents
{
    public class InputHandler : MonoBehaviour
    {
        private WeaponSwitcher _weaponSwitcher;
        private Player _player;

        private bool _isInit;

        public void Init(WeaponSwitcher weaponSwitcher, Player player)
        {
            _weaponSwitcher = weaponSwitcher;
            _player = player;
            
            _isInit = true;
        }

        private void Update()
        {
            if (_isInit == false)
                return;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.MakeShoot();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _weaponSwitcher.SwitchWeapon(WeaponType.Pistol);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _weaponSwitcher.SwitchWeapon(WeaponType.Rifle);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _weaponSwitcher.SwitchWeapon(WeaponType.Shotgun);
            }
        }
    }
}
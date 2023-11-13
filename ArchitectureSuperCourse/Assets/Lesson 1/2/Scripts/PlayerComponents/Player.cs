using Lesson_1.WeaponComponents;
using UnityEngine;

namespace Lesson_1.PlayerComponents
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private WeaponType _startWeapon;
        [SerializeField] private Gun _gun;

        public WeaponType StartWeapon => _startWeapon;

        public void Init(WeaponSwitcher weaponSwitcher)
        {
            _gun.Init(weaponSwitcher);
        }

        public void MakeShoot()
        {
            _gun.Shoot();
        }
    }
}
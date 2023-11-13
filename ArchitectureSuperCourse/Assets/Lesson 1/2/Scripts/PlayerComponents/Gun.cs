using Lesson_1.WeaponComponents;
using UnityEngine;

namespace Lesson_1.PlayerComponents
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Transform _shootPoint;

        [Header("Sounds (for fun)")]
        [SerializeField] private AudioSource _shoot;
        [SerializeField] private AudioSource _reload;
        
        private WeaponBase _utilizeWeapon;
        private WeaponSwitcher _weaponSwitcher;

        private Vector3 _forwardDirection => _shootPoint.forward;

        public void Init(WeaponSwitcher weaponSwitcher)
        {
            _weaponSwitcher = weaponSwitcher;
            _weaponSwitcher.WeaponChanged += ChangeWeapon;
            ChangeWeapon(_weaponSwitcher.CurrentWeapon);
        }

        public void OnDestroy()
        {
            _weaponSwitcher.WeaponChanged -= ChangeWeapon;
            
            if (_utilizeWeapon != null)
                _utilizeWeapon.Reloaded -= Reload;
        }

        public void Shoot()
        {
            _utilizeWeapon.Shoot(_forwardDirection, _shootPoint.position);
            _shoot.Play();
        }

        private void Reload()
        {
            _reload.Play();
        }

        private void ChangeWeapon(WeaponBase weapon)
        {
            if (_utilizeWeapon != null)
                _utilizeWeapon.Reloaded -= Reload;
            
            _utilizeWeapon = weapon;
            _utilizeWeapon.Reloaded += Reload;
        }
    }
}
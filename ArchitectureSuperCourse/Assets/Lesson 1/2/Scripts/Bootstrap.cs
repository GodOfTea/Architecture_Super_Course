using Lesson_1.PlayerComponents;
using Lesson_1.WeaponComponents;
using UnityEngine;

namespace Lesson_1.Task_2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private InputHandler _inputHandler;
        [SerializeField] private Player _player;
        [SerializeField] private BulletsPool _bulletsPool;
        
        private WeaponSwitcher _weaponSwitcher;

        private void Awake()
        {
            _bulletsPool.Init();
            _weaponSwitcher = new WeaponSwitcher(_player.StartWeapon, _bulletsPool);
            _player.Init(_weaponSwitcher);
            _inputHandler.Init(_weaponSwitcher, _player);
        }
    }
}
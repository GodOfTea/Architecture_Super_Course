using UnityEngine;

namespace Lesson_1.WeaponComponents
{
    public class Pistol : WeaponBase
    {
        private WeaponType _type;
        private int _currentBulletsInClip;
        
        public WeaponType Type => _type;

        public Pistol(BulletsPool pool) : base(pool)
        {
            _currentBulletsInClip = BulletsInClip;
        }

        public override void Shoot(Vector3 direction, Vector3 from)
        {
            Bullet bullet = _bulletsPool.GetFreeBullet();
            bullet.Spawn(direction * ShootForce, from);

            --_currentBulletsInClip;
            Debug.Log($"Патронов в пистолете {_currentBulletsInClip}/{BulletsInClip}");
            
            if (_currentBulletsInClip <= 0)
                Reload();
        }

        public override void Reload()
        {
            base.Reload();
            Debug.Log("Перезаряжаю пистолет");
            _currentBulletsInClip = BulletsInClip;
        }
    }
}
using UnityEngine;

namespace Lesson_1.WeaponComponents
{
    public class Shotgun : WeaponBase
    {
        private readonly float SpreadAngle = 25f;
        private int _currentBulletsInClip;

        public Shotgun(BulletsPool pool) : base(pool)
        {
            _currentBulletsInClip = BulletsInClip;
        }

        public override void Shoot(Vector3 direction, Vector3 from)
        {
            Bullet leftBullet = _bulletsPool.GetFreeBullet();
            Bullet middleBullet = _bulletsPool.GetFreeBullet();
            Bullet rightBullet = _bulletsPool.GetFreeBullet();

            Vector3 leftBulletDirection = Quaternion.Euler(0f, -SpreadAngle, 0f) * direction;
            Vector3 middleBulletDirection = direction;
            Vector3 rightBulletDirection = Quaternion.Euler(0f, SpreadAngle, 0f) * direction;
            
            leftBullet.Spawn(leftBulletDirection * ShootForce, from);
            middleBullet.Spawn(middleBulletDirection * ShootForce, from);
            rightBullet.Spawn(rightBulletDirection * ShootForce, from);
            
            _currentBulletsInClip -= 3;
            
            Debug.Log($"Патронов в дробовике {_currentBulletsInClip}/{BulletsInClip}");
            
            if (_currentBulletsInClip <= 0)
                Reload();
        }

        public override void Reload()
        {
            base.Reload();
            Debug.Log("Перезаряжаю дробовик");
            _currentBulletsInClip = BulletsInClip;
        }
    }
}
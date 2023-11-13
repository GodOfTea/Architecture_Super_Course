using System.Collections;
using Helpers;
using UnityEngine;

namespace Lesson_1.WeaponComponents
{
    public class Rifle : WeaponBase
    {
        private readonly float DelayBetweenBullets = 0.3f;
        private readonly int BulletsInRow = 3;

        private bool _isShooting;
        
        public Rifle(BulletsPool pool) : base(pool) { }

        public override void Shoot(Vector3 direction, Vector3 from)
        {
            if (_isShooting)
                return;

            CoroutineManager.StartRoutine(ShootWithDelay(direction, from));
        }

        public override void Reload()
        {
            
        }

        private IEnumerator ShootWithDelay(Vector3 direction, Vector3 from)
        {
            _isShooting = true;
            
            for (int i = 0; i < BulletsInRow; i++)
            {
                _bulletsPool.GetFreeBullet().Spawn(direction * ShootForce, from);
                yield return new WaitForSeconds(DelayBetweenBullets);
            }

            _isShooting = false;
        }
    }
}
using System;
using UnityEngine;

namespace Lesson_1.WeaponComponents
{
    public abstract class WeaponBase
    {
        protected readonly float ShootForce = 100f;
        protected readonly int BulletsInClip = 15;
        
        protected BulletsPool _bulletsPool;

        public event Action Reloaded;
        
        public WeaponBase(BulletsPool pool)
        {
            _bulletsPool = pool;
        }

        public abstract void Shoot(Vector3 direction, Vector3 from);

        public virtual void Reload()
        {
            Reloaded?.Invoke();
        }
    }
}
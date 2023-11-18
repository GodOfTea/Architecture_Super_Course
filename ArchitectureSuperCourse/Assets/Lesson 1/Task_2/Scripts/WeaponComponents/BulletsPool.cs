using PlayablesPlugins.PoolComponents;
using UnityEngine;

namespace Lesson_1.Task_2.WeaponComponents
{
    public class BulletsPool : PoolBase
    {
        [SerializeField] private Bullet _prefab;
        
        private PoolMono<Bullet> _pool;
        
        public void Init()
        {
            _pool = new PoolMono<Bullet>(_prefab, _poolObjectsCount, _isAutoExpand, _container);
        }

        public Bullet GetFreeBullet()
        {
            Bullet bullet = _pool.GetFreeElement();
            bullet.Init(_container);
            
            return bullet;
        }
    }
}
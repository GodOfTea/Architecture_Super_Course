using System;
using UnityEngine;

namespace PlayablesPlugins.PoolComponents
{
    public class PoolBase : MonoBehaviour
    {
        [SerializeField] protected int _poolObjectsCount;
        [SerializeField] protected bool _isAutoExpand;
        [SerializeField] protected Transform _container;

        private void Awake()
        {
            if (_container == null)
                _container = transform;
        }
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace PlayablesPlugins.PoolComponents
{
    public class PoolListMono<T> where T : MonoBehaviour
    {
        public T[] Prefabs { get; }
        
        public bool AutoExpand { get; set; }
        
        public Transform Container { get; }

        private List<T> _pool;
        
        public PoolListMono(T[] prefabs, int count, bool autoExpand)
        {
            Prefabs = prefabs;
            AutoExpand = autoExpand;
            Container = null;
            
            CreatePool(count);
        }

        public PoolListMono(T[] prefabs, int count, bool autoExpand, Transform container)
        {
            Prefabs = prefabs;
            AutoExpand = autoExpand;
            Container = container;
            
            CreatePool(count);
        }

        private void CreatePool(int count)
        {
            _pool = new List<T>();

            for (int i = 0; i < count; i++)
            {
                CreateObject();
            }
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            T randomPrefab = Prefabs[Random.Range(0, Prefabs.Length)];
            
            T createdObject = Object.Instantiate(randomPrefab, Container);
            createdObject.gameObject.SetActive(isActiveByDefault);
            _pool.Add(createdObject);

            return createdObject;
        }
        
        public bool HasFreeElement(out T freeElement)
        {
            foreach (var element in _pool)
            {
                if (!element.gameObject.activeInHierarchy)
                {
                    freeElement = element;
                    return true;
                }
            }

            freeElement = null;
            return false;
        }
        
        public T GetFreeElement()
        {
            if (HasFreeElement(out T freeElement))
            {
                freeElement.gameObject.SetActive(true);
                return freeElement;
            }

            if (AutoExpand)
            {
                return CreateObject(true);
            }

            throw new Exception($"There is no free elements in pool of type {typeof(T)}");
        }
    }
}

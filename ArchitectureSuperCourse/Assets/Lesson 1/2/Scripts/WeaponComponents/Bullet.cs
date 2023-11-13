using System.Collections;
using UnityEngine;

namespace Lesson_1.WeaponComponents
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private readonly float LifeTime = 3f;

        private Transform _poolContainer;
        [SerializeField] private Rigidbody _rigidbody;

        private bool _isInit;
        
        public void Init(Transform poolContainer)
        {
            if (_isInit)
                return;
            
            if (_rigidbody == null)
                _rigidbody = GetComponent<Rigidbody>();

            _poolContainer = poolContainer;
            _isInit = true;
        }
        
        public void Spawn(Vector3 force, Vector3 startPoint)
        {
            transform.parent = null;
            transform.position = startPoint;
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(force);

            StartCoroutine(LifeCircle());
        }

        private void Destroy()
        {
            gameObject.SetActive(false);
            transform.parent = _poolContainer;
            transform.localPosition = Vector3.zero;
            _rigidbody.isKinematic = true;
        }

        private IEnumerator LifeCircle()
        {
            yield return new WaitForSeconds(LifeTime);
            Destroy();
        }
    }
}
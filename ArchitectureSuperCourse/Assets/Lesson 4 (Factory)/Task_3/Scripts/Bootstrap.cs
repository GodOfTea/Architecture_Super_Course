using Factory.Task_3.SpawnerComponents;
using UnityEngine;

namespace Factory.Task_3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
                _coinSpawner.StartWork();
            
            if (Input.GetKeyDown(KeyCode.F))
                _coinSpawner.StopWork();
        }
    }
}
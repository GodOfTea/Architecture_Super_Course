using System;
using System.Collections;
using Factory.Task_3.CoinComponents;
using Factory.Task_3.FactoryComponents;
using Helpers;
using UnityEngine;

namespace Factory.Task_3.SpawnerComponents
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private CoinsFactory _coinsFactory;
        
        [Header("Data")]
        [SerializeField] private SpawnPointsList _spawnPointsList;

        private Coroutine _spawnCoroutine;
        
        public void StartWork()
        {
            StopWork();

            _spawnCoroutine = CoroutineManager.StartRoutine(WorkProcess());
        }

        public void StopWork()
        {
            CoroutineManager.StopRoutine(_spawnCoroutine);
        }

        private IEnumerator WorkProcess()
        {
            while (true)
            {
                SpawnPoint spawnPoint = _spawnPointsList.GetFreeSpawnPoint();

                if (spawnPoint == null)
                {
                    StopWork(); /* Все слоты заняты, не зачем дальше крутить спавнер */
                    break;
                }

                Coin coin = _coinsFactory.Get(GetRandomCoinType());
                spawnPoint.SetCoin(coin);
                coin.SetToPosition(spawnPoint.Transform);
                
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private CoinType GetRandomCoinType() =>
            (CoinType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(CoinType)).Length);
    }
}

using System;
using UnityEngine;

namespace Factory.Task_3.SpawnerComponents
{
    [Serializable]
    public class SpawnPointsList
    {
        [SerializeField] private SpawnPoint[] _spawnPoints;

        public SpawnPoint GetFreeSpawnPoint()
        {
            foreach (SpawnPoint spawnPoint in _spawnPoints)
            {
                if (spawnPoint.IsBooked == false)
                    return spawnPoint;
            }

            /* Этот код реализует описаную в SpawnPoint классе идею  */
            //SpawnPoint randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            //randomPoint.Clear();

            //return randomPoint;

            return null;
        }
    }
}
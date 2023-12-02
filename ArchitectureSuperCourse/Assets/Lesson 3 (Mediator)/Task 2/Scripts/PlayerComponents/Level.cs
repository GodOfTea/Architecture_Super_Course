using System;
using UnityEngine;

namespace Mediator.PlayerComponents
{
    public class Level
    {
        private readonly int _maxLevel;
        private readonly int _minLevel;

        private int _currentLevel;

        public event Action<int> LevelUpdated;

        public Level(int maxLevel, int minLevel)
        {
            _maxLevel = maxLevel;
            _minLevel = minLevel;
            _currentLevel = _minLevel;
        }

        public void IncreaseLevel()
        {
            _currentLevel += 1;

            if (_currentLevel >= _maxLevel)
            {
                _currentLevel = _maxLevel;
                
                Debug.Log("<color=red>Ты достиг центра вселенной... Ой, это из другой игры</color>");
                Debug.Log("<color=red>Я хотел сказать, ты достиг максимального лвл, грацЦцццЦ!!11!</color>");
            }
            
            LevelUpdated?.Invoke(_currentLevel);
        }

        public void Reset()
        {
            _currentLevel = _minLevel;
            LevelUpdated?.Invoke(_currentLevel);
        }
    }
}

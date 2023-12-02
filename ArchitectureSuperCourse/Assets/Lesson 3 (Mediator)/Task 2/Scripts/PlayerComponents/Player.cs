using System;
using UnityEngine;

namespace Mediator.PlayerComponents
{
    public class Player : MonoBehaviour, IGameplayPlayerEvents, ILosePlayerEvents
    {
        [Header("Settings")]
        [SerializeField] private int _damagePerClick = 10;
        
        [Header("Links")]
        [SerializeField] private InputHandler _input;
        
        [Space]
        [SerializeField] private PlayerData _data;

        private Level _level;
        private Health _health;

        private IRestarter _restarter;

        public IPlayerData Data => _data;

        public event Action<int> LevelUpdated;
        public event Action<int> HealthUpdated;
        public event Action HealthEnded;

        public void Init(IRestarter restarter)
        {
            _level = new Level(_data.MaxLevel, _data.MinLevel);
            _health = new Health(_data.MaxHealth);

            _restarter = restarter;

            _restarter.OnRestart += Restart;

            _input.LevelIncreased += OnLevelIncreased;
            _input.DamageGetted += OnDamageGetted;
            
            _level.LevelUpdated += OnLevelUpdated;
            _health.HealthUpdated += OnHealthUpdated;
            _health.HealthEnded += OnHealthEnded;
            _health.HealthEnded += _input.Disable;
            
            _input.Enable();
        }

        public void OnDestroy()
        {
            _restarter.OnRestart -= Restart;

            _input.LevelIncreased -= OnLevelIncreased;
            _input.DamageGetted -= OnDamageGetted;
            
            _level.LevelUpdated -= OnLevelUpdated;
            _health.HealthUpdated -= OnHealthUpdated;
            _health.HealthEnded -= OnHealthEnded;
            _health.HealthEnded += _input.Disable;
        }

        private void OnLevelIncreased()
        {
            _level.IncreaseLevel();
            _health.Recover();
        }

        private void OnDamageGetted()
        {
            _health.GetDamage(_damagePerClick);
        }

        private void Restart()
        {
            _level.Reset();
            _health.Recover();
            
            _input.Enable();
        }

        private void OnLevelUpdated(int value) => LevelUpdated?.Invoke(value);
        private void OnHealthUpdated(int value) => HealthUpdated?.Invoke(value);

        private void OnHealthEnded() => HealthEnded?.Invoke();
    }
}

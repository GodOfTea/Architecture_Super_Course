using System;

namespace Mediator.PlayerComponents
{
    public class Health
    {
        private readonly int _maxHealth;
        
        private int _currentHealth;

        public event Action HealthEnded;
        public event Action<int> HealthUpdated;
        
        public Health(int maxHealth)
        {
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }

        public void GetDamage(int value)
        {
            _currentHealth -= value;

            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                HealthEnded?.Invoke();
            }
            
            HealthUpdated?.Invoke(_currentHealth);
        }

        public void Recover()
        {
            _currentHealth = _maxHealth;
            HealthUpdated?.Invoke(_currentHealth);
        }
    }
}

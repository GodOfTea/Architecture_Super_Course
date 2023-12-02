using UnityEngine;
using UnityEngine.UI;

namespace Mediator.UIComponents.Player
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Slider _healthBar;

        public void Init(int maxHealth)
        {
            _healthBar.maxValue = maxHealth;
            UpdateHealth(maxHealth);
        }

        public void UpdateHealth(int value)
        {
            _healthBar.value = value;
        }
    }
}
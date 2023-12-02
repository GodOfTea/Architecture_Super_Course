using UnityEngine;

namespace Mediator.UIComponents.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private HealthView _healthView;
        [SerializeField] private LevelView _levelView;

        public void Init(int maxHealth, int startLevel)
        {
            _healthView.Init(maxHealth);
            _levelView.Init(startLevel);
        }
        
        public void UpdateHealth(int value)
        {
            _healthView.UpdateHealth(value);
        }

        public void UpdateLevel(int value)
        {
            _levelView.UpdateText(value);
        }
    }
}
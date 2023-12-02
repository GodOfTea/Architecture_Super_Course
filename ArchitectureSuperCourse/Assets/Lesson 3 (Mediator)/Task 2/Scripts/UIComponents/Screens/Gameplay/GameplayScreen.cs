using Mediator.PlayerComponents;
using Mediator.UIComponents.Screens;
using UnityEngine;

namespace Mediator.UIComponents.Player
{
    public class GameplayScreen : MonoBehaviour, IScreen
    {
        [SerializeField] private PlayerView _playerView;

        public void Init(IPlayerData playerData)
        {
            _playerView.Init(playerData.MaxHealth, playerData.MinLevel);
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void UpdateHealth(int value)
        {
            _playerView.UpdateHealth(value);
        }

        public void UpdateLevel(int value)
        {
            _playerView.UpdateLevel(value);
        }
    }
}
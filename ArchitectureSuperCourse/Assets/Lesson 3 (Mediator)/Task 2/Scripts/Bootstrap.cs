using Mediator.MediatorComponents;
using Mediator.PlayerComponents;
using Mediator.UIComponents.Lose;
using Mediator.UIComponents.Player;
using UnityEngine;

namespace Mediator
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [Header("Screens")]
        [SerializeField] private GameplayScreen _gameplayScreen;
        [SerializeField] private LoseScreen _loseScreen;

        private Restart _restart;
        private GameplayMediator _gameplayMediator;
        private LoseMediator _loseMediator;

        private void Awake()
        {
            _restart = new Restart();
            
            _player.Init(_restart);
            
            _gameplayScreen.Init(_player.Data);
            
            _gameplayMediator = new GameplayMediator(_player, _gameplayScreen);
            _loseMediator = new LoseMediator(_player, _loseScreen, _restart);
            
            
        }
    }
}
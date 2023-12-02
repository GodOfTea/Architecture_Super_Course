using Mediator.PlayerComponents;
using Mediator.UIComponents.Player;

namespace Mediator.MediatorComponents
{
    public class GameplayMediator
    {
        private readonly IGameplayPlayerEvents _playerEvents;
        private readonly GameplayScreen _gameplayScreen;

        public GameplayMediator(IGameplayPlayerEvents playerEvents, GameplayScreen gameplayScreen)
        {
            _playerEvents = playerEvents;
            _gameplayScreen = gameplayScreen;

            _playerEvents.HealthUpdated += _gameplayScreen.UpdateHealth;
            _playerEvents.LevelUpdated += _gameplayScreen.UpdateLevel;
        }

        ~GameplayMediator()
        {
            _playerEvents.HealthUpdated -= _gameplayScreen.UpdateHealth;
            _playerEvents.LevelUpdated -= _gameplayScreen.UpdateLevel;
        }
    }
}
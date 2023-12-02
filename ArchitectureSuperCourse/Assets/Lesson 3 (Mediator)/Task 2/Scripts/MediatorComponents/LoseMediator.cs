using Mediator.PlayerComponents;
using Mediator.UIComponents.Lose;

namespace Mediator.MediatorComponents
{
    public class LoseMediator
    {
        private ILosePlayerEvents _playerEvents;
        private LoseScreen _loseScreen;
        private IRestartEnabler _restartEnabler;

        public LoseMediator(ILosePlayerEvents playerEvents, LoseScreen loseScreen, IRestartEnabler restartEnabler)
        {
            _playerEvents = playerEvents;
            _loseScreen = loseScreen;
            _restartEnabler = restartEnabler;

            _playerEvents.HealthEnded += _loseScreen.Show;
            _loseScreen.GameRestarting += SendMessageAboutRestart;
        }

        ~LoseMediator()
        {
            _playerEvents.HealthEnded -= _loseScreen.Show;
            _loseScreen.GameRestarting -= SendMessageAboutRestart;
        }

        private void SendMessageAboutRestart()
        {
            _restartEnabler.Enable();
        }
    }
}
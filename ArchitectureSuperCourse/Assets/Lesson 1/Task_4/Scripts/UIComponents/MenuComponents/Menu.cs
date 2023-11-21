using Lesson_1.Task_4.UIComponents.GameplayComponents;
using UnityEngine;

namespace Lesson_1.Task_4.UIComponents.MenuComponents
{
    public class Menu : ScreenBase
    {
        [SerializeField] private GameplayScreen _gameplayScreen;

        [SerializeField] private MenuButton[] _menuButtons;
        
        protected override void Awake()
        {
            base.Awake();
            Show();

            foreach (var menuButton in _menuButtons)
                menuButton.ButtonClicked += StartGame;
        }

        private void StartGame(WinCondition winCondition)
        {
            foreach (var menuButton in _menuButtons)
                menuButton.ButtonClicked -= StartGame;
            
            Hide();
            _gameplayScreen.SetWinCondition(winCondition);
            _gameplayScreen.Show();
        }
    }
}

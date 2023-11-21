using System.Collections.Generic;
using Lesson_1.Task_4.Data;
using Lesson_1.Task_4.Enumirations;
using UnityEngine;

namespace Lesson_1.Task_4.UIComponents.GameplayComponents
{
    public class GameplayScreen : ScreenBase
    {
        [SerializeField] private CirclesList _circlesList;
        [SerializeField] private CircleData[] _circleDatas;

        private WinCondition _winCondition;
        
        protected override void Awake()
        {
            base.Awake();
            Hide();
        }

        public void SetWinCondition(WinCondition winCondition)
        {
            _winCondition = winCondition;
        }

        public override void Show()
        {
            base.Show();
            _circlesList.Init(_circleDatas, _winCondition);
            _circlesList.GameEnded += EndGame;
        }

        private void EndGame()
        {
            _circlesList.GameEnded -= EndGame;

            Debug.Log("YOU WIIIIIIN!!!! CONGRATS!!");
            Debug.Log("pls restart game if u wanna try again");
            Debug.Log("<color=red>MEOW =^-^=</color>");
        }
    }
}

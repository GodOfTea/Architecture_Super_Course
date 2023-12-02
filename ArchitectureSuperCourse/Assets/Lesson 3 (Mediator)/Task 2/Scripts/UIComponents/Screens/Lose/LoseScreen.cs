using System;
using Mediator.UIComponents.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace Mediator.UIComponents.Lose
{
    public class LoseScreen : MonoBehaviour, IScreen
    {
        [SerializeField] private Canvas _canvas;
        [SerializeField] private Button _restartButton;

        public event Action GameRestarting;

        private void Start()
        {
            Hide();
        }

        public void Show()
        {
            _canvas.enabled = true;
            _restartButton.onClick.AddListener(Restart);
        }

        public void Hide()
        {
            _canvas.enabled = false;
        }

        private void Restart()
        {
            Hide();
            _restartButton.onClick.RemoveListener(Restart);
            GameRestarting?.Invoke();
        }
    }
}
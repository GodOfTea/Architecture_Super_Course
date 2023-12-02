using System;
using Lesson_2.Task_2.UIComponents;
using UnityEngine;

namespace Lesson_2.Task_2.Characters
{
    public class BotInput : MonoBehaviour
    {
        [SerializeField] private StateButton _workButton;
        [SerializeField] private StateButton _restButton;

        public event Action WorkStarting;
        public event Action RestStarting;
        
        private void OnEnable()
        {
            _workButton.OnClick += StartWork;
            _restButton.OnClick += StartRest;
        }

        private void OnDisable()
        {
            _workButton.OnClick -= StartWork;
            _restButton.OnClick -= StartRest;
        }

        private void StartWork() => WorkStarting?.Invoke();
        private void StartRest() => RestStarting?.Invoke();
    }
}

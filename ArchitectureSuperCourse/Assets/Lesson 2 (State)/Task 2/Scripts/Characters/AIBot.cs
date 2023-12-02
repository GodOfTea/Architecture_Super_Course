using Lesson_2.Task_2.StateMachine;
using Lesson_2.Task_2.StateMachine.States;
using Lesson_2.Task_2.WorkComponents;
using UnityEngine;

namespace Lesson_2.Task_2.Characters
{
    public class AIBot : MonoBehaviour
    {
        [SerializeField] private BotInput _input;
        [SerializeField] private AIBotConfig _config;

        private AIStateMachine _stateMachine;

        public AIBotConfig Config => _config;
        public Transform Transform => transform;

        public void Init()
        {
            _stateMachine = new AIStateMachine(this, typeof(RestState));
            _input.WorkStarting += WorkStarting;
            _input.RestStarting += RestStarting;
        }

        /* По хорошему, не делать так напрямую присваивание WorkType, но, как мне кажется, для примера должно подойти
            Но, если есть предложение, как это поменять, я с удовольствием бы прочитал */
        private void WorkStarting() => _stateMachine.InputHandler(_config.GetWork(WorkType.Mining));
        private void RestStarting() => _stateMachine.InputHandler(_config.GetWork(WorkType.Rest));
    }
}
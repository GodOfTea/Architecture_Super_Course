using Lesson_2.Task_2.Characters;
using Lesson_2.Task_2.WorkComponents;
using UnityEngine;

namespace Lesson_2.Task_2.StateMachine.States
{
    public class AIState : IState
    {
        protected IStateSwitcher StateSwitcher;
        protected AIStateMachineData Data;

        private AIBot _bot;

        protected Transform BotTransform => _bot.Transform;
        protected AIBotConfig Config => _bot.Config;

        public AIState(IStateSwitcher stateSwitcher, AIStateMachineData data, AIBot bot)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _bot = bot;
        }

        public virtual void Enter()
        {
            Log("");
        }

        public virtual void Exit() { }

        public virtual void InputHandler(IWork work) { }

        protected virtual void Log(string text)
        {
            Debug.Log(text);
        }
    }
}
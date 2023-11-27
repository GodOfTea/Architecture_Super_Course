using Lesson_2.Task_2.Characters;
using Lesson_2.Task_2.WorkComponents;

namespace Lesson_2.Task_2.StateMachine.States
{
    public class RestState : WorkState
    {
        private readonly string _stateLog = "Start Rest";
        
        public RestState(IStateSwitcher stateSwitcher, AIStateMachineData data, AIBot bot) : base(stateSwitcher, data, bot) { }

        protected override void Log(string text)
        {
            base.Log(_stateLog);
        }
    }
}
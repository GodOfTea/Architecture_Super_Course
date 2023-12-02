using Lesson_2.Task_2.StateMachine.States;

namespace Lesson_2.Task_2.StateMachine
{
    public interface IStateSwitcher
    {
        void Switch<T>() where T : IState;
    }
}
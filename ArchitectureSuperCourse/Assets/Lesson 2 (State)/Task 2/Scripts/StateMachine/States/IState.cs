using Lesson_2.Task_2.WorkComponents;

namespace Lesson_2.Task_2.StateMachine.States
{
    public interface IState
    {
        void Enter();
        void Exit();
        void InputHandler(IWork work);
    }
}
using Lesson_2.Task_2.Characters;
using Lesson_2.Task_2.StateMachine;
using Lesson_2.Task_2.StateMachine.States;
using Lesson_2.Task_2.WorkComponents;

public class WorkState : AIState
{
    public WorkState(IStateSwitcher stateSwitcher, AIStateMachineData data, AIBot bot) : base(stateSwitcher, data, bot)
    { }

    public override void InputHandler(IWork work)
    {
        Data.SetWork(work);
        StateSwitcher.Switch<MovementState>();
    }
}

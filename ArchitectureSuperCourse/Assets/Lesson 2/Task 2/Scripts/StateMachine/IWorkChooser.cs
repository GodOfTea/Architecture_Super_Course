using System;
using Lesson_2.Task_2.WorkComponents;

namespace Lesson_2.Task_2.StateMachine
{
    public interface IWorkChooser
    {
        Action GetWork(WorkType type);
    }
}
using UnityEngine;

namespace Lesson_2.Task_2.WorkComponents
{
    public interface IWork
    {
        WorkType Type { get; }
        Vector3 WorkPosition { get; }
    }
}
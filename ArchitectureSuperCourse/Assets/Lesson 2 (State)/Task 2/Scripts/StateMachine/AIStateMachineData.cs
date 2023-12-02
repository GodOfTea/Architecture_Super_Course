using Lesson_2.Task_2.WorkComponents;
using UnityEngine;

public class AIStateMachineData
{
    private IWork _currentWork;

    public Vector3 CurrentWorkPosition => _currentWork.WorkPosition;
    public WorkType CurrentWorkType => _currentWork.Type;

    public void SetWork(IWork work)
    {
        _currentWork = work;
    }
}

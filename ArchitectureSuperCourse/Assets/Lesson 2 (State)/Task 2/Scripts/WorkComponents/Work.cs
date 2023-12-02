using System;
using UnityEngine;

namespace Lesson_2.Task_2.WorkComponents
{
    [Serializable]
    public class Work : IWork
    {
        [SerializeField] private WorkType _type;
        [SerializeField] private Vector3 _workPosition;

        public WorkType Type => _type;
        public Vector3 WorkPosition => _workPosition;
    }
}

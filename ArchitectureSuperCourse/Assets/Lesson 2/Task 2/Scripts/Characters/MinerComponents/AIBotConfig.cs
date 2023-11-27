using System.Linq;
using Lesson_2.Task_2.WorkComponents;
using UnityEngine;

namespace Lesson_2.Task_2.StateMachine
{
    [CreateAssetMenu(menuName = "Data/Lesson_2/StateMachine", fileName = "AIBotConfig")]
    public class AIBotConfig : ScriptableObject
    {
        [SerializeField] private Work[] _works;
        [SerializeField] private float _moveTime;
        [SerializeField] private float _rotationTime;

        public float MoveTime => _moveTime;
        public float RotationTime => _rotationTime;

        public IWork GetWork(WorkType type)
        {
            return _works.FirstOrDefault(w => w.Type == type);
        }
    }
}

using Lesson_1.Task_4.Enumirations;
using UnityEngine;

namespace Lesson_1.Task_4.Data
{
    [CreateAssetMenu(menuName = "Data/Circle", fileName = "New CircleData")]
    public class CircleData : ScriptableObject
    {
        [SerializeField] private CircleType _circleType;
        [SerializeField] private Color _color;

        public CircleType CircleType => _circleType;
        public Color Color => _color;
    }
}

using System.Collections.Generic;
using Lesson_1.Task_4.Enumirations;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/WinCondition", fileName = "New WinCondition")]
public class WinCondition : ScriptableObject
{
    [SerializeField] private List<CircleType> _types;

    public IEnumerable<CircleType> WinTypes => _types;
}

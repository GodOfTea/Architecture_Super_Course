using System;
using System.Collections.Generic;
using Lesson_1.Task_4.Enumirations;

namespace Lesson_1.Task_4.UIComponents.GameplayComponents
{
    public class WinConditionHandler
    {
        private Dictionary<CircleType, int> _winConditionsMap;

        public event Action Win;

        private int _winConditionsCount;
        
        public WinConditionHandler(WinCondition winCondition)
        {
            _winConditionsMap = new Dictionary<CircleType, int>();

            foreach (var circleType in winCondition.WinTypes)
            {
                _winConditionsMap.Add(circleType, 0);
            }

            _winConditionsCount = _winConditionsMap.Count;
        }

        public void AddCircle(CircleType type)
        {
            if (CheckAvailabilityOfType(type))
            {
                _winConditionsMap[type] += 1;
            }
        }

        public void RemoveCircle(CircleType type)
        {
            if (CheckAvailabilityOfType(type) == false)
                return;
            
            _winConditionsMap[type] -= 1;

            if (_winConditionsMap[type] == 0)
            {
                _winConditionsCount -= 1;
                if (_winConditionsCount == 0)
                {
                    Win?.Invoke();
                }
            }
        }

        private bool CheckAvailabilityOfType(CircleType type) => _winConditionsMap.ContainsKey(type);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Lesson_1.Task_4.Data;
using Lesson_1.Task_4.Enumirations;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lesson_1.Task_4.UIComponents.GameplayComponents
{
    public class CirclesList : MonoBehaviour
    {
        [SerializeField] private Circle[] _circles;

        private WinConditionHandler _winConditionHandler;

        public event Action GameEnded;

        private void OnValidate()
        {
            if (_circles.Length == 0)
            {
                _circles = transform.GetComponentsInChildren<Circle>();
            }
        }

        public void Init(CircleData[] datas, WinCondition winCondition)
        {
            _winConditionHandler = new WinConditionHandler(winCondition);
            _winConditionHandler.Win += Win;
            CreateCircles(datas);
        }

        /* В теории может произойти случай, когда не будет 1-го или 2-х цветов при спавне. Очень маловероятно, но все равно возможно.
            Но я решил опустить обработку этого случая, в рамках этой задачи. */
        private void CreateCircles(CircleData[] datas)
        {
            foreach (var circle in _circles)
            {
                CircleData data = datas[Random.Range(0, datas.Length)];
                circle.Init(data);
                circle.Destroied += RemoveCircle;
                
                _winConditionHandler.AddCircle(data.CircleType);
            }
        }

        private void RemoveCircle(Circle circle, CircleType type)
        {
            circle.Destroied -= RemoveCircle;
            _winConditionHandler.RemoveCircle(type);
        }

        /* С точки зрения архитектуры и логики не самое хорошее решение, но я немного спешил с окончанием этой таской,
            поэтому решил оставить так (: */
        private void Win()
        {
            _winConditionHandler.Win -= Win;

            foreach (Circle circle in _circles.Where(c => c.IsDestroyed == false))
            {
                circle.Destruct();
            }
            
            GameEnded?.Invoke();
        }
    }
}

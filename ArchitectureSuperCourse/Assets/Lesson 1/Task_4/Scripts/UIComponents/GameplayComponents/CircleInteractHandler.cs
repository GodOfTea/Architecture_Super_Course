using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lesson_1.Task_4.UIComponents.GameplayComponents
{
    public class CircleInteractHandler : MonoBehaviour, IPointerClickHandler
    {
        public event Action OnClicked;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClicked?.Invoke();
        }
    }
}

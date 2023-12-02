using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lesson_2.Task_2.UIComponents
{
    public class StateButton : MonoBehaviour, IPointerClickHandler
    {
        public event Action OnClick;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            OnClick?.Invoke();
        }
    }
}

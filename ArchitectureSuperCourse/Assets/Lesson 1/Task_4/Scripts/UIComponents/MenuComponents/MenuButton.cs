using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lesson_1.Task_4.UIComponents.MenuComponents
{
    public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        /* Как альтернатива, чтоб убрать прямую ссылку на условия победы из кнопки, можно отдельно составить
            словарь с ссылками на кнопки и условия, и там уже зполнить его */
        [SerializeField] private WinCondition _winCondition;
        
        private MenuButtonAnimation _animation;
        
        public event Action<WinCondition> ButtonClicked;

        private void Awake()
        {
            _animation = new MenuButtonAnimation(transform);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _animation.HighlightedPlay();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _animation.ReleasedPlay();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _animation.PressedPlay();
            ButtonClicked?.Invoke(_winCondition);
        }
    }
}

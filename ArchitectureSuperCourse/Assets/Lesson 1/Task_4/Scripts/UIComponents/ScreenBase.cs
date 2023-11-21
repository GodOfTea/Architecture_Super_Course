using UnityEngine;

namespace Lesson_1.Task_4.UIComponents
{
    [RequireComponent(typeof(Canvas))]
    public class ScreenBase : MonoBehaviour
    {
        private Canvas _canvas;

        protected virtual void Awake()
        {
            _canvas = GetComponent<Canvas>();
        }

        public virtual void Show()
        {
            _canvas.enabled = true;
            
        }

        public virtual void Hide()
        {
            _canvas.enabled = false;
        }
    }
}

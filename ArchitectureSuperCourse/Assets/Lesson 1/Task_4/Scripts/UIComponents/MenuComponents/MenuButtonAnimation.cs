using DG.Tweening;
using UnityEngine;

namespace Lesson_1.Task_4.UIComponents.MenuComponents
{
    public class MenuButtonAnimation
    {
        private readonly Vector3 HighlightedScale = new Vector3(1.15f, 1.15f);
        private readonly Vector3 DefaultScale = new Vector3(1f, 1f);
        private readonly Vector3 PressedScale = new Vector3(0.85f, 0.85f);
        private readonly float _animationTime = 0.3f;
        
        private Transform _button;
        
        public MenuButtonAnimation(Transform button)
        {
            _button = button;
        }

        public void HighlightedPlay()
        {
            _button.DOScale(HighlightedScale, _animationTime).SetEase(Ease.Linear);
        }
        
        public void PressedPlay()
        {
            _button.DOScale(PressedScale, _animationTime).SetEase(Ease.Linear).SetLoops(2, LoopType.Yoyo);
        }

        public void ReleasedPlay()
        {
            _button.DOScale(DefaultScale, _animationTime).SetEase(Ease.Linear);
        }
    }
}

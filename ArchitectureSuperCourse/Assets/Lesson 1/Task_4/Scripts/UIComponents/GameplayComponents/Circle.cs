using System;
using Lesson_1.Task_4.Data;
using Lesson_1.Task_4.Enumirations;
using Lesson_1.Task_4.UIComponents.MenuComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson_1.Task_4.UIComponents.GameplayComponents
{
    public class Circle : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private CircleInteractHandler _interactHandler;
        [SerializeField] private CircleData _data;

        [Space]
        [SerializeField] private CircleView _view;

        private bool _isDestroyed;

        public bool IsDestroyed => _isDestroyed;
        
        public event Action<Circle, CircleType> Destroied;

        public void Init(CircleData data)
        {
            _data = data;
            
            _view.SetColor(_data.Color);
            _interactHandler.OnClicked += OnClicked;
        }

        public void Destruct()
        {
            _interactHandler.OnClicked -= OnClicked;
        }

        private void OnClicked()
        {
            Destroied?.Invoke(this, _data.CircleType);
            _image.enabled = false;
            _isDestroyed = true;
            
            Destruct();
        }
    }
}

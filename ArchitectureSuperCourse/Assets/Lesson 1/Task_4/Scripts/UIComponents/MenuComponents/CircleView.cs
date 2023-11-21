using System;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson_1.Task_4.UIComponents.MenuComponents
{
    [Serializable]
    public class CircleView
    {
        [SerializeField] private Image _image;

        public void SetColor(Color color)
        {
            _image.color = color;
        }
    }
}
using System;
using Factory.Task_2.UIComponents;
using UnityEngine;

namespace Factory.Task_2.IconComponents
{
    [Serializable]
    public class Icon
    {
        [SerializeField] private string _name;
        [SerializeField] private ScreenType _screenType;
        [SerializeField] private Sprite _sprite;

        public ScreenType ScreenType => _screenType;
        public Sprite Sprite => _sprite;
    }
}
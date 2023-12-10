using System;
using System.Linq;
using Factory.Task_2.IconComponents;
using Factory.Task_2.UIComponents;
using UnityEngine;

namespace Factory.Task_2.FactoryComponents
{
    [Serializable]
    public class CoinIconFactory : IconFactory
    {
        [SerializeField] private Icon[] _icons;
        
        public override Icon Get(ScreenType screenType)
        {
            Icon icon = _icons.FirstOrDefault(o => o.ScreenType == screenType);

            if (icon == null)
                throw new NullReferenceException($"Icon is null with {screenType} screen type");

            return icon;
        }
    }
}
using System;
using Factory.Task_2.IconComponents;
using UnityEngine;

namespace Factory.Task_2.FactoryComponents
{
    public class FactoryChooser : MonoBehaviour
    {
        /* Можно было бы сюда сделать SO config для каждой фабрики, но думаю в данной задаче это не супер критично */
        [SerializeField] private CoinIconFactory _coinIconFactory;
        [SerializeField] private EnergyIconFactory _energyIconFactory;

        public IconFactory GetFactory(IconType iconType)
        {
            switch (iconType)
            {
                case IconType.Coin:
                    return _coinIconFactory;
                
                case IconType.Energy:
                    return _energyIconFactory;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(iconType), iconType, null);
            }
        }
    }
}
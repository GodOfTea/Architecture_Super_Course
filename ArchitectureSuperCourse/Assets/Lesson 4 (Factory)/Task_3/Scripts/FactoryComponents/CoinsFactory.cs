using System;
using Factory.Task_3.CoinComponents;
using UnityEngine;

namespace Factory.Task_3.FactoryComponents
{
    [CreateAssetMenu(menuName = "Data/Factory/CoinsFactory", fileName = "CoinsFactory")]
    public class CoinsFactory : ScriptableObject
    {
        [SerializeField] private Coin _red, _yellow, _green;

        public Coin Get(CoinType type)
        {
            Coin instance = Instantiate(ChooseCoin(type));
            return instance;
        }

        private Coin ChooseCoin(CoinType type)
        {
            switch (type)
            {
                case CoinType.Red:
                    return _red;
                
                case CoinType.Green:
                    return _green;
                
                case CoinType.Yellow:
                    return _yellow;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
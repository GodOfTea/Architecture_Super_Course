using UnityEngine;

namespace Mediator.PlayerComponents
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Mediator/Player", order = 0)]
    public class PlayerData : ScriptableObject, IPlayerData
    {
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _maxLevel;
        [SerializeField] private int _minLevel;

        public int MaxHealth => _maxHealth;
        
        public int MaxLevel => _maxLevel;
        public int MinLevel => _minLevel;
    }
}
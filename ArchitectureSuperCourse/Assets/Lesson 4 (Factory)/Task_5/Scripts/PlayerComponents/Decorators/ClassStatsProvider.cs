using System;

namespace Factory.Task_5.PlayerComponents.Decorators
{
    public class ClassStatsProvider
    {
        private readonly int ClassModifier = 3; 
        
        private ClassType _classType;
        
        public ClassStatsProvider(ClassType classType)
        {
            _classType = classType;
        }

        public CharacterStats GetStats(CharacterStats stats)
        {
            switch (_classType)
            {
                case ClassType.Mage:
                    stats.GetStat(StatType.Wisdom).Add(ClassModifier);
                    break;
                case ClassType.Barbarian:
                    stats.GetStat(StatType.Wisdom).Add(ClassModifier);
                    break;
                case ClassType.Thief:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
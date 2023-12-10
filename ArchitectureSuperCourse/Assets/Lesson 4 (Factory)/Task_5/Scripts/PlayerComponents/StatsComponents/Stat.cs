using Factory.Task_5.PlayerComponents.StatsComponents;

namespace Factory.Task_5.PlayerComponents
{
    public class Stat : IStat
    {
        private readonly int _defaultValue = 10;
        
        private StatType _statType;
        private int _value;

        public StatType StatType => _statType;
        public int Value => _value;

        public Stat(StatType statType)
        {
            _statType = statType;
            _value = _defaultValue;
        }

        public Stat(StatType statType, int value)
        {
            _statType = statType;
            _value = value;
        }
    }
}
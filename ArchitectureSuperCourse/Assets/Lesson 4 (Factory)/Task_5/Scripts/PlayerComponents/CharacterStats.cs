using System.Linq;
using Factory.Task_5.PlayerComponents.StatsComponents;

namespace Factory.Task_5.PlayerComponents
{
    public class CharacterStats
    {
        private Stat[] _stats;

        public CharacterStats()
        {
            _stats = new[]
            {
                new Stat(StatType.Strength),
                new Stat(StatType.Agility),
                new Stat(StatType.Wisdom)
            };
        }

        public Stat GetStat(StatType type) => _stats.FirstOrDefault(o => o.StatType == type);
    }
}
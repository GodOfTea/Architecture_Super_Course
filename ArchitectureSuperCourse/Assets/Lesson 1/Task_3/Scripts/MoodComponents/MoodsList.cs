using System.Collections.Generic;
using Lesson_1.Task_3.Enumerations;

namespace Lesson_1.Task_3.MoodComponents
{
    public class MoodsList
    {
        private Dictionary<MoodType, IMood> _moods;

        public MoodsList()
        {
            _moods = new Dictionary<MoodType, IMood>()
            {
                { MoodType.Annoyed, new Annoyed() },
                { MoodType.Calm, new Calm() },
                { MoodType.Flattered, new Flattered() }
            };
        }

        public IMood GetMood(MoodType type) => _moods[type];
    }
}
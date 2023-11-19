using System.Collections.Generic;
using Lesson_1.Task_3.Enumerations;
using Lesson_1.Task_3.MoodComponents;

namespace Lesson_1.Task_3.NPCComponents
{
    public class TradeHandler
    {
        private TradeObjectsList _tradeObjectsList;
        private Dictionary<IMood, TradeType> _tradeTypes;

        public TradeHandler(MoodsList moodsList)
        {
            _tradeTypes = new Dictionary<IMood, TradeType>
            {
                { moodsList.GetMood(MoodType.Calm), TradeType.Armors },
                { moodsList.GetMood(MoodType.Flattered), TradeType.Fruits }
            };

            _tradeObjectsList = new TradeObjectsList();
        }

        public string GetObjectsForTrade(IMood mood)
        {
            return _tradeObjectsList.GetObjects(_tradeTypes[mood]);
        }
    }
}
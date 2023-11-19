using System.Collections.Generic;
using Lesson_1.Task_3.Enumerations;

namespace Lesson_1.Task_3.NPCComponents
{
    public class TradeObjectsList
    {
        /* Тут вместо string можно взять какую-то коллекцию объектов или SO. Для примера, думаю, подойдет просто string */
        private Dictionary<TradeType, string> _objectsToTrade;

        public TradeObjectsList()
        {
            _objectsToTrade = new Dictionary<TradeType, string>()
            {
                { TradeType.Armors, "Armors"},
                { TradeType.Fruits, "Fruits"}
            };
        }

        public string GetObjects(TradeType type)
        {
            return _objectsToTrade[type];
        }
    }
}
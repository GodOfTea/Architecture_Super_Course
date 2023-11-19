using Lesson_1.Task_3.EasterEggComponents;
using Lesson_1.Task_3.MoodComponents;
using UnityEngine;

namespace Lesson_1.Task_3.NPCComponents
{
    public class Seller : MonoBehaviour, IInteractable
    {
        [SerializeField] private SellerView _view;
        [SerializeField] private EasterEgg _easterEgg;
        
        private MoodHandler _moodHandler;
        private TradeHandler _tradeHandler;

        private IMood _currentMood;

        private int _goodTradesCount;

        public void Init(MoodsList moodsList)
        {
            _goodTradesCount = 0;
            
            _moodHandler = new MoodHandler(moodsList);
            _tradeHandler = new TradeHandler(moodsList);
            _view.UpdateMood(_moodHandler.StartMoodIndex);
            _currentMood = _moodHandler.CurrentMood;

            _moodHandler.MoodChanged += ChangeMood;
            _moodHandler.MoodValueChanged += _view.UpdateMood;
        }

        private void OnDestroy()
        {
            _moodHandler.MoodChanged -= ChangeMood;
            _moodHandler.MoodValueChanged -= _view.UpdateMood;
        }

        public void Trade()
        {
            _currentMood.React();
            
            if (_currentMood.CanTrade)
            {
                string tradeObjects = _tradeHandler.GetObjectsForTrade(_currentMood);
                Debug.Log($"Seller show you {tradeObjects} for trade");
                ++_goodTradesCount;

                if (_goodTradesCount >= 5)
                {
                    _easterEgg.Play();
                    _goodTradesCount = 0;
                }
            }
        }

        public void BadInteraction()
        {
            _moodHandler.DecreaseMood();
        }

        public void GoodInteraction()
        {
            _moodHandler.IncreaseMood();
        }

        private void ChangeMood(IMood mood)
        {
            _currentMood = mood;
        }
    }
}

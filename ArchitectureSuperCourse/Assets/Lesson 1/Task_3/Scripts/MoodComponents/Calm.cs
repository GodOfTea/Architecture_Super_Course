using UnityEngine;

namespace Lesson_1.Task_3.MoodComponents
{
    public class Calm : IMood
    {
        public bool CanTrade { get; }

        public Calm()
        {
            CanTrade = true;
        }

        public void React()
        {
            Debug.Log("Да, можешь посмотреть на то, что я сделал.");
        }
    }
}
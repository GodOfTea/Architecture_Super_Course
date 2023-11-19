using UnityEngine;

namespace Lesson_1.Task_3.MoodComponents
{
    public class Flattered : IMood
    {
        public bool CanTrade { get; }

        public Flattered()
        {
            CanTrade = true;
        }

        public void React()
        {
            Debug.Log("Ой знаешь, а я ещё фрукты выращиваю, на своей ферме. Хочешь попробовать?");
        }
    }
}
using UnityEngine;

namespace Lesson_1.Task_3.MoodComponents
{
    public class Annoyed : IMood
    {
        public bool CanTrade { get; }

        public Annoyed()
        {
            CanTrade = false;
        }

        public void React()
        {
            Debug.Log("Да я тебе в жизни ничего не продам! Пшл вон!");
        }
    }
}
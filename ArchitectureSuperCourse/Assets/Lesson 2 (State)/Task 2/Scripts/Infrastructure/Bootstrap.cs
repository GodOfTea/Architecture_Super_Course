using Lesson_2.Task_2.Characters;
using UnityEngine;

namespace Lesson_2.Task_2.Infrastructure
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private AIBot _bot;

        private void Awake()
        {
            _bot.Init();
        }
    }
}

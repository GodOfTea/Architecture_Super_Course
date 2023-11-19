using Lesson_1.Task_3.MoodComponents;
using Lesson_1.Task_3.NPCComponents;
using Lesson_1.Task_3.PlayerComponents;
using UnityEngine;

namespace Lesson_1.Task_3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Seller _seller;
        [SerializeField] private InputHandler _inputHandler;
        
        private MoodsList _moodsList;

        private void Awake()
        {
            _moodsList = new MoodsList();
            _seller.Init(_moodsList);
            _inputHandler.Init(_seller);
        }
    }
}
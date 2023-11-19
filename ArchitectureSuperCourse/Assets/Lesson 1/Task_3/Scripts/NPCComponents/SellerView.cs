using TMPro;
using UnityEngine;

namespace Lesson_1.Task_3.NPCComponents
{
    public class SellerView : MonoBehaviour
    {
        private const string MoodTemplate = "Mood is: {0}";
        
        [SerializeField] private TextMeshProUGUI _moodText;

        public void UpdateMood(int moodValue)
        {
            _moodText.text = string.Format(MoodTemplate, moodValue);
        }
    }
}

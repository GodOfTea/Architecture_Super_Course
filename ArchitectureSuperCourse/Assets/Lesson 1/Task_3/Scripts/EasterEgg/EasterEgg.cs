using UnityEngine;

namespace Lesson_1.Task_3.EasterEggComponents
{
    public class EasterEgg : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void Play()
        {
            Debug.Log("<color=red>С тобой приятно иметь дело!</color>");
            _animator.SetTrigger("Deal");
        }
    }
}

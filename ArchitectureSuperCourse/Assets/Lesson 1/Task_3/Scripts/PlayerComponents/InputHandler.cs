using Lesson_1.Task_3.NPCComponents;
using UnityEngine;

namespace Lesson_1.Task_3.PlayerComponents
{
    public class InputHandler : MonoBehaviour
    {
        private Seller _seller;

        public void Init(Seller seller)
        {
            _seller = seller;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _seller.Trade();
            }
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                _seller.GoodInteraction();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                _seller.BadInteraction();
            }
        }
    }
}
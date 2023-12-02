using System;
using UnityEngine;

namespace Mediator.PlayerComponents
{
    public class InputHandler : MonoBehaviour
    {
        public event Action LevelIncreased;
        public event Action DamageGetted;

        private bool _isEnable;
        
        public void Enable()
        {
            _isEnable = true;
        }

        public void Disable()
        {
            _isEnable = false;
        }
        
        private void Update()
        {
            if (_isEnable == false)
                return;
        
            if (Input.GetKeyDown(KeyCode.L))
                LevelIncreased?.Invoke();
            
            if (Input.GetKeyDown(KeyCode.D))
                DamageGetted?.Invoke();
        }
    }
}

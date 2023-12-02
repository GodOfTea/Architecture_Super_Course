using System;
using TMPro;
using UnityEngine;

namespace Mediator.UIComponents.Player
{
    public class LevelView : MonoBehaviour
    {
        private readonly string _levelTextTemplate = "Level: {0}";
        
        [SerializeField] private TextMeshProUGUI _levelText;

        public void Init(int startLevel)
        {
            UpdateText(startLevel);
        }
        
        public void UpdateText(int level)
        {
            _levelText.text = String.Format(_levelTextTemplate, level);
        }
    }
}
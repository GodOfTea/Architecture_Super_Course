using Factory.Task_2.IconComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Factory.Task_2.UIComponents
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private Image _coinImage;
        [SerializeField] private Image _energyImage;
        
        public void Show(Icon coinIcon, Icon energyIcon)
        {
            _coinImage.sprite = coinIcon.Sprite;
            _energyImage.sprite = energyIcon.Sprite;
        }
    }
}
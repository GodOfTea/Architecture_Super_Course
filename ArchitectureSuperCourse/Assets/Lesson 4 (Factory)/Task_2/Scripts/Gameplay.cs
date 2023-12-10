using Factory.Task_2.FactoryComponents;
using Factory.Task_2.IconComponents;
using Factory.Task_2.UIComponents;
using UnityEngine;
using Screen = Factory.Task_2.UIComponents.Screen;

namespace Factory.Task_2
{
    public class Gameplay : MonoBehaviour
    {
        [SerializeField] private Screen _screen;
        [SerializeField] private FactoryChooser _factoryChooser;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                ChangeScreen(ScreenType.MainMenu);
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                ChangeScreen(ScreenType.Store);
            
            if (Input.GetKeyDown(KeyCode.Alpha3))
                ChangeScreen(ScreenType.Gameplay);
        }

        private void ChangeScreen(ScreenType screenType)
        {
            Icon coin = _factoryChooser.GetFactory(IconType.Coin).Get(screenType);
            Icon energy = _factoryChooser.GetFactory(IconType.Energy).Get(screenType);

            _screen.Show(coin, energy);
        }
    }
}
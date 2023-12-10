using Factory.Task_2.IconComponents;
using Factory.Task_2.UIComponents;

namespace Factory.Task_2.FactoryComponents
{
    public abstract class IconFactory
    {
        public abstract Icon Get(ScreenType screenType);
    }
}
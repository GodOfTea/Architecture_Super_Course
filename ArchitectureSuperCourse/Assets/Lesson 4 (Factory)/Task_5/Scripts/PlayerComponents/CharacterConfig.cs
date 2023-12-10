using Factory.Task_5.PlayerComponents.StatsComponents;
using UnityEngine;

namespace Factory.Task_5.PlayerComponents
{
    [CreateAssetMenu(fileName = "New CharacterConfig", menuName = "Data/Decorator/CharacterConfig", order = 0)]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private RaceType _race;
        [SerializeField] private ClassType _class;
        [SerializeField] private PassiveAbilityType _passiveAbility;

        private CharacterStats _stats;

        public void Calculate()
        {
            if (_stats == null)
                _stats = new CharacterStats();
            
            
        }
    }
    
    
    /* дефолт 10. раса дает +3, класс умножает на х2, и способность дает + и - */
}
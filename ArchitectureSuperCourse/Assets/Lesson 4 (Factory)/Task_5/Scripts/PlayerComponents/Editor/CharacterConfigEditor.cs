using System;
using UnityEditor;
using UnityEngine;

namespace Factory.Task_5.PlayerComponents.Editor
{
    [CustomEditor(typeof(CharacterConfig))]
    public class CharacterConfigEditor : UnityEditor.Editor
    {
        private const string StrengthStatTemplate = "Strength: {0}";
        private const string IntelligenceStatTemplate = "Intelligence: {0}";
        private const string AgilityStatTemplate = "Agility: {0}";

        private CharacterConfig _target;
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            _target = (CharacterConfig)target;

            if (GUILayout.Button("Calculate Stats"))
            {
                _target.Calculate();
            }
            
            EditorGUILayout.Space(20f);
            EditorGUILayout.LabelField("My stats:");
            EditorGUILayout.LabelField(string.Format(StrengthStatTemplate, 2));
            EditorGUILayout.LabelField(string.Format(IntelligenceStatTemplate, 3));
            EditorGUILayout.LabelField(string.Format(AgilityStatTemplate, 5));
        }
    }
}
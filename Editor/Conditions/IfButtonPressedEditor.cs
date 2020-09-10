using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfButtonIsPressed))]
    public class IfButtonPressedEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfButtonIsPressed)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Button";
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName} Is Pressed";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
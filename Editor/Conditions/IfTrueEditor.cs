using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfBoolIsTrue))]
    public class IfTrueEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfBoolIsTrue)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "True";
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName}";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
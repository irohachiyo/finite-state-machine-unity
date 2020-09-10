using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfOnEvent))]
    public class IfOnEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfOnEvent)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "On Event";
            var newName = $"If {(myTarget.reverse ? "Not ": "")}{variableName}";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
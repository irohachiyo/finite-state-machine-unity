using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfIntIsValue))]
    public class IfIntIsValueEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfIntIsValue)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Int";
            var valueString = myTarget.value.ToString();
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName} is {valueString}";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
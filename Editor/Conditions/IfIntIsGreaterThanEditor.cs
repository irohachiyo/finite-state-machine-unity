using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfIntIsGreaterThan))]
    public class IfIntIsGreaterThanEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfIntIsGreaterThan)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Int";
            var newName = $"If {variableName} {(myTarget.reverse ? "<" : ">")}{(myTarget.inclusive ? "=" : "")} {myTarget.threshold}";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
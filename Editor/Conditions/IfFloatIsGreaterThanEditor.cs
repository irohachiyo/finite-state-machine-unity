using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfFloatIsGreaterThan))]
    public class IfFloatIsGreaterThanEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfFloatIsGreaterThan)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Float";
            var newName = $"If {variableName} {(myTarget.reverse ? "<" : ">")}{(myTarget.inclusive ? "=" : "")} {myTarget.threshold}";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
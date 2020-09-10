using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfStringIs))]
    public class IfStringIsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfStringIs)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "String";
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName} is \"{myTarget.equals}\"";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
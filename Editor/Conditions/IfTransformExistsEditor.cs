using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfTransformExists))]
    public class IfTransformExistsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfTransformExists)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Transform";
            var newName = $"If {(myTarget.reverse ? "No " : "")}{variableName} Exists";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
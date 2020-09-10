using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfButtonWasReleasedThisFrame))]
    public class IfButtonWasReleasedThisFrameEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfButtonWasReleasedThisFrame)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Button";
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName} Was Released This Frame";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
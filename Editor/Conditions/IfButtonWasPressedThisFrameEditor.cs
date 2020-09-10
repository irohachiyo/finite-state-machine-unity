using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfButtonWasPressedThisFrame))]
    public class IfButtonWasPressedThisFrameEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfButtonWasPressedThisFrame)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "Button";
            var newName = $"If {(myTarget.reverse ? "Not " : "")}{variableName} Was Pressed This Frame";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
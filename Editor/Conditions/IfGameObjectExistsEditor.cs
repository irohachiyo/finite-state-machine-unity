using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(IfGameObjectExists))]
    public class IfGameObjectExistsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (IfGameObjectExists)target;
            var variableMonoBehaviour = (MonoBehaviour)myTarget.variable;
            var variableName = variableMonoBehaviour ? variableMonoBehaviour.name : "GameObject";
            var newName = string.Format("If {0}{1} Exists", myTarget.reverse ? "No " : "", variableName);
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
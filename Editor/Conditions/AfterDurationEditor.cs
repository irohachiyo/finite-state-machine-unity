using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(AfterDuration))]
    public class AfterDurationEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var myTarget = (AfterDuration)target;
            var newName = $"{(myTarget.reverse ? "Within " : "After ")}{myTarget.Duration} Seconds";
            if (myTarget.name != newName) myTarget.name = newName;
        }
    }
}
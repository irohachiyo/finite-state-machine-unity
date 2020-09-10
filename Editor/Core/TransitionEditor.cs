using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(Transition))]
    public class TransitionEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var transition = (Transition)target;
            var stateName = transition.transitionTo ? transition.transitionTo.name : "State";
            var newName = $"To {stateName}";;
            if (transition.name != newName) transition.name = newName;
        }
    }
}
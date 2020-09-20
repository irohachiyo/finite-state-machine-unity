using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IrohaChiyo.FiniteStateMachine
{
    [CustomEditor(typeof(NamedCondition), true)]
    public class NamedConditionEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var labeledCOndition = (NamedCondition)target;
            var newName = labeledCOndition.GetConditionName();
            if (target.name != newName) target.name = newName;
        }
    }
}

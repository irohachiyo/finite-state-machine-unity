using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfGlobalStringIs : NamedCondition
    {
        public GlobalStringVariable variable;
        public string text;
        public bool reverse;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global String")} Is {(reverse ? "Not " : "")}{(text != "" ? text : "Blank")}";
        }

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            condition.Value = variable.Value == text ^ reverse;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfGlobalIntIsValue : NamedCondition
    {
        public GlobalIntVariable variable;
        public int value;
        public bool reverse;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global Int")} Is {(reverse ? "Not " : "")}{value}";
        }

        private BoolVariable condition;

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            condition.Value = variable.Value == value ^ reverse;
        }
    }
}
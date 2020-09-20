using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfGlobalIntIsGreaterThan : NamedCondition
    {
        public GlobalIntVariable variable;
        public int threshold;
        public bool reverse;
        public bool inclusive;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global Int")} {(reverse ? "<" : ">")}{(inclusive ? "=" : "")} {threshold}";
        }

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            if (variable.Value == threshold)
            {
                if (inclusive)
                {
                    condition.Value = true;
                }
                else
                {
                    condition.Value = false;
                }
            }
            else
            {
                condition.Value = variable.Value > threshold ^ reverse;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

namespace IrohaChiyo.FiniteStateMachine
{
    public class IfGlobalFloatIsGreaterThan : NamedCondition
    {
        public GlobalFloatVariable variable;
        public float threshold;
        public bool reverse;
        public bool inclusive;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global Float")} {(reverse ? "<" : ">")}{(inclusive ? "=" : "")} {threshold}";
        }

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            if (variable.Value == threshold)
            {
                condition.Value = inclusive;
            }
            else
            {
                condition.Value = variable.Value > threshold ^ reverse;
            }
        }
    }
}

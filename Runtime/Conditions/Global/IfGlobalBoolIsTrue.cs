using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

namespace IrohaChiyo.FiniteStateMachine
{
    public class IfGlobalBoolIsTrue : NamedCondition
    {
        public GlobalBoolVariable variable;
        public bool reverse;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global Bool")} Is {(reverse ? "False" : "True")}";
        }

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            condition.Value = variable.Value ^ reverse;
        }
    }
}

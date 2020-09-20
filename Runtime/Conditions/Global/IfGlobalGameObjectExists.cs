using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfGlobalGameObjectExists : NamedCondition
    {
        public GlobalGameObjectVariable variable;
        public bool reverse;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Global GameObject")} {(reverse ? "Doesn't " : "")}Exist";
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
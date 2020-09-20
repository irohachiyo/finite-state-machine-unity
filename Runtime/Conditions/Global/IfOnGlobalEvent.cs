using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfOnGlobalEvent : NamedCondition
    {
        public GlobalEventVariable variable;
        public bool reverse;

        private BoolVariable condition;

        public override string GetConditionName()
        {
            var asset = (ScriptableObject)variable;
            return $"If {(asset ? asset.name : "Globale Event")} Is {(reverse ? "Not " : "")}Invoked";
        }

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void OnEnable()
        {
            condition.Value = reverse;
            variable.Value += OnEvent;
        }

        private void OnDisable()
        {
            variable.Value -= OnEvent;
        }

        private void OnEvent(GameObject arg)
        {
            condition.Value = !reverse;
        }
    }
}

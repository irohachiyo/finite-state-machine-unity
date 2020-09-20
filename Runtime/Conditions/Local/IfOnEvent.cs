using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;
using System;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfOnEvent : MonoBehaviour
    {
        public EventVariable variable;
        public bool reverse;

        private BoolVariable condition;

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
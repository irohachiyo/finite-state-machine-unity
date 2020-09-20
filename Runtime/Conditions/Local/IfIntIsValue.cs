using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfIntIsValue : MonoBehaviour
    {
        public IntVariable variable;
        public int value;
        public bool reverse;

        private BoolVariable condition;

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            condition.Value = (variable.Value == value) ^ reverse;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfFloatIsGreaterThan : MonoBehaviour
    {
        public FloatVariable variable;
        public float threshold;
        public bool reverse;
        public bool inclusive;

        private BoolVariable condition;

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
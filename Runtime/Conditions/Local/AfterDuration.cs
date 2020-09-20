using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class AfterDuration : MonoBehaviour
    {
        [SerializeField] private float duration;
        public bool reverse;

        private BoolVariable condition;
        private WaitForSeconds waitForDuration;

        public float Duration => duration;

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
            waitForDuration = new WaitForSeconds(duration);
        }

        private void OnEnable()
        {
            StartCoroutine(F());
        }

        private IEnumerator F()
        {
            condition.Value = false ^ reverse;
            yield return waitForDuration;
            condition.Value = true ^ reverse;
        }
    }
}
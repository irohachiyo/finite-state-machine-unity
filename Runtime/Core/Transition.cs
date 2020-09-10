using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    public class Transition : MonoBehaviour
    {
        public State transitionTo;

        private BoolVariable[] conditions;
        private State parentState;

        private void Awake()
        {
            conditions = GetComponentsInChildren<BoolVariable>();
            parentState = GetComponentInParent<State>();
        }

        public bool AllConditionsAreSatisfied()
        {
            var conditionIsSatisfied = true;
            {
                if (conditions.Length > 0)
                {
                    foreach (var condition in conditions)
                    {
                        if (!condition.Value)
                        {
                            conditionIsSatisfied = false;
                            break;
                        }
                    }
                }
                else
                {
                    conditionIsSatisfied = false;
                }
            }
            return conditionIsSatisfied;
        }
    }
}
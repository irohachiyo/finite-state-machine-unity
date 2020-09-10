using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    public class State : MonoBehaviour
    {
        public GameObject[] required;

        private Transition[] transitions;

        private void Awake()
        {
            transitions = GetComponentsInChildren<Transition>();
        }

        private void OnEnable()
        {
            foreach (var component in required)
            {
                if (!component.activeSelf)
                {
                    component.SetActive(true);
                }
            }
        }

        public void DisableUnusedComponents(State nextState)
        {
            foreach (var prevStateComponent in required)
            {
                var isRequired = false;
                foreach (var nextStateComponent in nextState.required)
                {
                    if (prevStateComponent == nextStateComponent)
                    {
                        isRequired = true;
                        break;
                    }
                }
                if (!isRequired && prevStateComponent.activeSelf)
                {
                    prevStateComponent.SetActive(false);
                }
            }
        }

        private void LateUpdate()
        {
            foreach (var transition in transitions)
            {
                if (transition.AllConditionsAreSatisfied())
                {
                    DisableUnusedComponents(transition.transitionTo);
                    gameObject.SetActive(false);
                    transition.transitionTo.gameObject.SetActive(true);
                    break;
                }
            }
        }
    }
}
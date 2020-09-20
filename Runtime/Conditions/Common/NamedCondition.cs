using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    public abstract class NamedCondition : MonoBehaviour
    {
        public abstract string GetConditionName();
    }
}

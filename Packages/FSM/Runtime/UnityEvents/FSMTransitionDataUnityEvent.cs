using System;
using UnityEngine.Events;
using UltEvents;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// None generic Unity Event of type `FSMTransitionData`. Inherits from `UnityEvent&lt;FSMTransitionData&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FSMTransitionDataUnityEvent : UltEvent<FSMTransitionData> { }
}

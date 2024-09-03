using System;
using UnityEngine.Events;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `AtomBaseVariable`. Inherits from `UnityEvent&lt;AtomBaseVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AtomBaseVariableUnityEvent : UltEvent<AtomBaseVariable> { }
}

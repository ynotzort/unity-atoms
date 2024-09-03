using System;
using UnityEngine.Events;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `int`. Inherits from `UnityEvent&lt;int&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntUnityEvent : UltEvent<int> { }
}

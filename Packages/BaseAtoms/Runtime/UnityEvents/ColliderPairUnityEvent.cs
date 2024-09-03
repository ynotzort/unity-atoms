using System;
using UnityEngine.Events;
using UnityEngine;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `ColliderPair`. Inherits from `UnityEvent&lt;ColliderPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderPairUnityEvent : UltEvent<ColliderPair> { }
}

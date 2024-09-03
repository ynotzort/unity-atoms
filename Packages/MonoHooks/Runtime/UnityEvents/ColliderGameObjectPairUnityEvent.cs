using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;
using UltEvents;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `ColliderGameObjectPair`. Inherits from `UnityEvent&lt;ColliderGameObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectPairUnityEvent : UltEvent<ColliderGameObjectPair> { }
}

using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;
using UltEvents;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `CollisionGameObjectPair`. Inherits from `UnityEvent&lt;CollisionGameObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectPairUnityEvent : UltEvent<CollisionGameObjectPair> { }
}

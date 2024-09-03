using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;
using UltEvents;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `CollisionGameObject`. Inherits from `UnityEvent&lt;CollisionGameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectUnityEvent : UltEvent<CollisionGameObject> { }
}

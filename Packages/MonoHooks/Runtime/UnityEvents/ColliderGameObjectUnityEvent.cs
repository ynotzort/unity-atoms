using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;
using UltEvents;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `ColliderGameObject`. Inherits from `UnityEvent&lt;ColliderGameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectUnityEvent : UltEvent<ColliderGameObject> { }
}

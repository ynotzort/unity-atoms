using System;
using UnityEngine.Events;
using UnityEngine;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `GameObject`. Inherits from `UnityEvent&lt;GameObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectUnityEvent : UltEvent<GameObject> { }
}

using System;
using UnityEngine.Events;
using UnityEngine;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Vector3`. Inherits from `UnityEvent&lt;Vector3&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3UnityEvent : UltEvent<Vector3> { }
}

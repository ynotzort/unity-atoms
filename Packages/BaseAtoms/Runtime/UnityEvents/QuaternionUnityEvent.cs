using System;
using UnityEngine.Events;
using UnityEngine;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Quaternion`. Inherits from `UnityEvent&lt;Quaternion&gt;`.
    /// </summary>
    [Serializable]
    public sealed class QuaternionUnityEvent : UltEvent<Quaternion> { }
}

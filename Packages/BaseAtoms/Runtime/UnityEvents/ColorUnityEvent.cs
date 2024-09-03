using System;
using UnityEngine.Events;
using UnityEngine;
using UltEvents;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Color`. Inherits from `UnityEvent&lt;Color&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorUnityEvent : UltEvent<Color> { }
}

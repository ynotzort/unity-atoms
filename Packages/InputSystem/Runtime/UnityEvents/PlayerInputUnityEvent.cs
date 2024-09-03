using System;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UltEvents;

namespace UnityAtoms.InputSystem
{
    /// <summary>
    /// None generic Unity Event of type `PlayerInput`. Inherits from `UnityEvent&lt;PlayerInput&gt;`.
    /// </summary>
    [Serializable]
    public sealed class PlayerInputUnityEvent : UltEvent<PlayerInput> { }
}

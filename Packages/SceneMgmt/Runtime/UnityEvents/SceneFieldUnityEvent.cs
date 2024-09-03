using System;
using UnityEngine.Events;
using UnityAtoms.SceneMgmt;
using UltEvents;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// None generic Unity Event of type `SceneField`. Inherits from `UnityEvent&lt;SceneField&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SceneFieldUnityEvent : UltEvent<SceneField> { }
}

using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools.Events
{
    public sealed class MonoAwakeEvent : MonoBehaviour
    {
        public UnityEvent OnAwake;

        private void Awake() => OnAwake?.Invoke();
    }
}
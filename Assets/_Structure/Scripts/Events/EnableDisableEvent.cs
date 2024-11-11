using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools.Events
{
    public sealed class EnableDisableEvent : MonoBehaviour
    {
        public UnityEvent OnEnableEvent;
        public UnityEvent OnDisableEvent;

        private void OnEnable() => OnEnableEvent?.Invoke();
        private void OnDisable() => OnDisableEvent?.Invoke();
    }
}
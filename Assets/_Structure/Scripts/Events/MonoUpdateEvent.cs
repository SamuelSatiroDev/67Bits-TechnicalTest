using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools.Events
{
    public sealed class MonoUpdateEvent : MonoBehaviour
    {
        public UnityEvent OnUpdate;

        private void Update() => OnUpdate?.Invoke();
    }
}
using UnityEngine;
using UnityEngine.Events;

namespace GameManager.UnityEventSystem
{
    public sealed class UnityEventInvoke : MonoBehaviour
    {
        public UnityEvent OnEvent;

        public void HandlerInvoke() => OnEvent?.Invoke();
    }
}
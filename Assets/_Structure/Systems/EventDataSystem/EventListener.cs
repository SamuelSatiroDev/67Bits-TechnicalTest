using UnityEngine;
using UnityEngine.Events;

namespace GameManager.EventDataSystem
{
    public sealed class EventListener : MonoBehaviour
    {
        [SerializeField] private EventData _eventData;
        public UnityEvent OnEvent;
        public UnityEvent<int> OnEventInt;
        public UnityEvent<float> OnEventFloat;
        public UnityEvent<string> OnEventString;
        public UnityEvent<string> OnEventStringInt;
        public UnityEvent<Transform> OnEventTransform;

        private void OnEnable()
        {
            _eventData.OnEvent += OnUnityEvent;
            _eventData.OnEventInt += OnUnityEvent;
            _eventData.OnEventFloat += OnUnityEvent;
            _eventData.OnEventString += OnUnityEvent;
            _eventData.OnEventTransform += OnUnityEvent;
        }

        private void OnDisable()
        {
            _eventData.OnEvent -= OnUnityEvent;
            _eventData.OnEventInt -= OnUnityEvent;
            _eventData.OnEventFloat -= OnUnityEvent;
            _eventData.OnEventString -= OnUnityEvent;
            _eventData.OnEventTransform -= OnUnityEvent;
        }

        public void OnUnityEvent() => OnEvent?.Invoke();
        public void OnUnityEvent(int value)
        {
            OnEventInt?.Invoke(value);
            OnEventStringInt?.Invoke(value.ToString());
        }
        public void OnUnityEvent(float value) => OnEventFloat?.Invoke(value);
        public void OnUnityEvent(string value) => OnEventString?.Invoke(value);
        public void OnUnityEvent(Transform value) => OnEventTransform?.Invoke(value);
    }
}

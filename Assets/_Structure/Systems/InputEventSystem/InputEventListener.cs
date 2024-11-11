using UnityEngine;
using UnityEngine.Events;

namespace GameManager.InputDataSystem
{
    public sealed class InputEventListener : MonoBehaviour
    {
        [SerializeField] private InputEventData _inputEventData;
        public UnityEvent<Vector2> OnInputAction;
        public UnityEvent OnInputActionStoped;

        private void OnEnable() => _inputEventData.OnInputAction += HandlerInputAction;

        private void OnDisable() => _inputEventData.OnInputAction -= HandlerInputAction;

        private void HandlerInputAction(Vector2 callbackContext)
        {
            OnInputAction?.Invoke(callbackContext);

            if (callbackContext == Vector2.zero)
            {
                OnInputActionStoped?.Invoke();
            }
        }
    }
}
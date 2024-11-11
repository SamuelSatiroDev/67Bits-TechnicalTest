using UnityEngine;
using UnityEngine.InputSystem;

namespace GameManager.InputDataSystem
{
    [CreateAssetMenu(fileName = "InputEventData", menuName = "GameManager/Input System/InputEventData")]
    public sealed class InputEventData : ScriptableObject
    {
        public System.Action<Vector2> OnInputAction;

        public void HandlerInputAction(InputAction.CallbackContext callbackContext)
        {
            if (callbackContext.valueType != typeof(Vector2))
            {
                return;
            }

            OnInputAction?.Invoke(callbackContext.ReadValue<Vector2>());
        }
    }
}
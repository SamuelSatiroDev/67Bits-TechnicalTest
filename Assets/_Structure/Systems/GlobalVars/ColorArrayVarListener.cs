using UnityEngine;
using UnityEngine.Events;

namespace GameManager.GlobalVariables
{
    public sealed class ColorArrayVarListener : MonoBehaviour
    {
        [SerializeField] private ColorArrayVarData _colorArrayVarData;

        [SerializeField] private bool _initialize = true;
        [Space(10)]

        public UnityEvent<Color> OnValueChanged;

        private void OnEnable()
        {
            if (_initialize == false)
            {
                return;
            }

            _colorArrayVarData.OnValueChanged.AddListener(HandlerValueChanged);
        }

        private void OnDisable()
        {
            if (_initialize == false)
            {
                return;
            }

            _colorArrayVarData.OnValueChanged.RemoveListener(HandlerValueChanged);
        }

        public void HandlerValueChanged(Color value) => OnValueChanged?.Invoke(value);
    }
}
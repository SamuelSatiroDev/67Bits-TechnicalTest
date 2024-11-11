using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools
{
    public sealed class FloatToString : MonoBehaviour
    {
        [SerializeField] private string _prefix;
        [SerializeField] private string _suffix;

        [Space(10)]

        public UnityEvent<string> OnStringChanged;

        public void HandlerSetString(float value)
        {
            string stringValue = $"{_prefix}{value}{_suffix}";
            OnStringChanged?.Invoke(stringValue);
        }
    }
}
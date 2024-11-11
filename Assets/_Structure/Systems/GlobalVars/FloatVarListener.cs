using UnityEngine;
using UnityEngine.Events;

namespace GameManager.GlobalVariables
{
    [System.Serializable]
    public struct FloatComparer
    {
        public FloatVarData valueComparer;
        public ComparerValueType _comparerValueType;
        public UnityEvent<float> OnValue;
        public UnityEvent<float> OnElse;

        public void HandlerComparer(float value)
        {
            switch (_comparerValueType)
            {
                case ComparerValueType.Equal:
                    if (value == valueComparer.Value)
                    {
                        OnValue?.Invoke(value);
                    }
                    else
                    {
                        OnElse?.Invoke(value);
                    }
                    break;
                case ComparerValueType.GreaterThanOrEqual:
                    if (value >= valueComparer.Value)
                    {
                        OnValue?.Invoke(value);
                    }
                    else
                    {
                        OnElse?.Invoke(value);
                    }
                    break;
                case ComparerValueType.LessThanOrEqual:
                    if (value <= valueComparer.Value)
                    {
                        OnValue?.Invoke(value);
                    }
                    else
                    {
                        OnElse?.Invoke(value);
                    }
                    break;

                case ComparerValueType.LessThan:
                    if (value < valueComparer.Value)
                    {
                        OnValue?.Invoke(value);
                    }
                    else
                    {
                        OnElse?.Invoke(value);
                    }
                    break;

                case ComparerValueType.GreaterThan:
                    if (value > valueComparer.Value)
                    {
                        OnValue?.Invoke(value);
                    }
                    else
                    {
                        OnElse?.Invoke(value);
                    }
                    break;
            }
        }
    }

    public sealed class FloatVarListener : MonoBehaviour
    {
        [SerializeField] private FloatVarData _floatVarData;
        [SerializeField] private bool _initialize = true;
        [Space(10)]

        [SerializeField] private FloatComparer[] _floatComparers = new FloatComparer[] { };
        public UnityEvent<float> OnValueChanged;

        private void OnEnable()
        {
            if(_initialize == false)
            {
                return;
            }

            HandlerValueChanged(_floatVarData.Value);
            _floatVarData.OnValueChanged.AddListener(HandlerValueChanged);
        }

        private void OnDisable()
        {
            if (_initialize == false)
            {
                return;
            }

            _floatVarData.OnValueChanged.RemoveListener(HandlerValueChanged);
        }

        public void HandlerValueChanged(float value)
        {
            OnValueChanged?.Invoke(value);

            foreach (FloatComparer floatComparer in _floatComparers)
            {
                floatComparer.HandlerComparer(value);
            }
        }

        public void HandlerEvaluate()
        {
            OnValueChanged?.Invoke(_floatVarData.Value);

            foreach (FloatComparer floatComparer in _floatComparers)
            {
                floatComparer.HandlerComparer(_floatVarData.Value);
            }
        }
    }
}
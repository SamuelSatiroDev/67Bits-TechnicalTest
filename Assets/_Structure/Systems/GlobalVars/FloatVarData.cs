using UnityEngine;
using UnityEngine.Events;

namespace GameManager.GlobalVariables
{
    [CreateAssetMenu(fileName = "FloatVarData", menuName = "GameManager/Global Variables/Float Var")]
    public sealed class FloatVarData : ScriptableObject
    {
        [SerializeField] private float _value;

        public UnityEvent<float> OnValueChanged;

        public float Value 
        { 
            get => _value;

            set
            {
                _value = value;
                OnValueChanged?.Invoke(_value);
            } 
        }

        public void HandlerAddValue(float add) => Value += add;
        public void HandlerSetValue(float set) => Value = set;
        public void HandlerAddValue(FloatVarData add) => Value += add.Value;
        public void HandlerSetValue(FloatVarData set) => Value = set.Value;
    }
}


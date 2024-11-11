using UnityEngine;
using UnityEngine.Events;

namespace GameManager.GlobalVariables
{
    [CreateAssetMenu(fileName = "ColorArrayVarData", menuName = "GameManager/Global Variables/Color Array Var")]
    public sealed class ColorArrayVarData : ScriptableObject
    {
       [SerializeField] private Color[] _colors = new Color[] {};

        public UnityEvent<Color> OnValueChanged;

        public void HandlerSelectColor(int colorIndex)
        {
            if(colorIndex >= _colors.Length || colorIndex <= 0 || _colors.Length <= 0)
            {
                return;
            }

            OnValueChanged?.Invoke(_colors[colorIndex]);
        }

        public void HandlerSelectColor(FloatVarData colorIndex)
        {
            if (colorIndex.Value >= _colors.Length || colorIndex.Value <= 0 || _colors.Length <= 0)
            {
                return;
            }

            OnValueChanged?.Invoke(_colors[(int)colorIndex.Value]);
        }

        public void HandlerSelectColor(float colorIndex)
        {
            if (colorIndex >= _colors.Length || colorIndex <= 0 || _colors.Length <= 0)
            {
                return;
            }

            OnValueChanged?.Invoke(_colors[(int)colorIndex]);
        }
    }
}
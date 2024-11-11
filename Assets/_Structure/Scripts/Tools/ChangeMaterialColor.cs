using UnityEngine;

namespace GameManager.Tools
{
    public sealed class ChangeMaterialColor : MonoBehaviour
    {
        [SerializeField] private Material _material;

        public void HandlerChangeColor(Color newColor)
        {
            _material.color = newColor;
        }
    }
}
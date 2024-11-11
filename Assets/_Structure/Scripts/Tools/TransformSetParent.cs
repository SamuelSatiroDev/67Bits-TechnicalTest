using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformSetParent : MonoBehaviour
    {
        [SerializeField] private Transform _parent;

        public void HandlerSetParent(Transform parent) => parent.SetParent(_parent);
    }
}
using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools
{
    public sealed class TransformGetChilds : MonoBehaviour
    {
        [SerializeField] private Transform _parent;

        public UnityEvent<Transform> OnChildTransform;
        public UnityEvent OnGetInSequenceCompleted;

        public void HandlerGetInSequence()
        {
            if (_parent.childCount > 0)
            {
                int childIndex = _parent.childCount - 1;
                OnChildTransform?.Invoke(_parent.GetChild(childIndex).transform);
            }

            if (_parent.childCount <= 0)
            {
                OnGetInSequenceCompleted?.Invoke();
            }
        }
    }
}
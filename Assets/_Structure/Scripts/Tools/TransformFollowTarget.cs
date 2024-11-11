using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformFollowTarget : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _offset;
        [SerializeField] private float _smoothSpeed = 0.125f;

        private void LateUpdate()
        {
            if (_target == null)
            {
                return;
            }

            Vector3 desiredPosition = _target.position + _offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
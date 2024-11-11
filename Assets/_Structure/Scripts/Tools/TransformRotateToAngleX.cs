using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformRotateToAngleX : MonoBehaviour
    {
        [SerializeField] private float _angle;
        [SerializeField] private Transform _targetRotate;

        [Header("Read Only")]
        [SerializeField] private Vector3 _rotateSpeed;

        private void Update()
        {
            if(_targetRotate == null)
            {
                return;
            }

            if (_rotateSpeed != Vector3.zero)
            {
                _targetRotate.localRotation = Quaternion.Euler(_angle, 0, 0);
            }
            else
            {
                _targetRotate.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }

        public void HandlerSetTarget(Transform newTarget) => _targetRotate = newTarget;

        public void HandlerSetTargetNull() => _targetRotate = null;

        public void HandlerSetTargetOnlyIfItHasNull(Transform newTarget)
        {
            if(_targetRotate != null)
            {
                return;
            }

            _targetRotate = newTarget;
        }

        public void HandlerSetRotationSpeed(Vector2 vector2) => _rotateSpeed = new Vector3(vector2.x, 0, vector2.y);
    }
}
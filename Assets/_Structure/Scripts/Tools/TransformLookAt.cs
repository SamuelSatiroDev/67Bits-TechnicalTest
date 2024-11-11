using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformLookAt : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Transform _lootAt;

        [Space(10)]

        [SerializeField] private bool _enableXAxis = true;
        [SerializeField] private bool _enableYAxis = true;
        [SerializeField] private bool _enableZAxis = true;

        private void Update()
        {
            if(_target == null || _lootAt == null)
            {
                return;
            }

            Vector3 direction = _lootAt.position - _target.position;

            direction.x = _enableXAxis ? direction.x : 0f;
            direction.y = _enableYAxis ? direction.y : 0f;
            direction.z = _enableZAxis ? direction.z : 0f;

            if (direction == Vector3.zero)
            {
                return;
            }

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            _target.rotation = targetRotation;
        }

        public void HandlerSetLookAt(Transform newLookAt) => _lootAt = newLookAt;

        public void HandlerSetTarget(Transform newTarget) => _target = newTarget;
    }
}
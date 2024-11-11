using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools
{
    public sealed class TransformSetPosition : MonoBehaviour
    {
        [SerializeField] private float _speed;

        public UnityEvent<Vector3> OnTranslate;

        [Header("Read Only")]
        [SerializeField] private Vector3 _positionSpeed;

        private void Update()
        {
            Vector3 movement = new Vector3(_positionSpeed.x, 0, _positionSpeed.z) * _speed * Time.deltaTime;
            transform.localPosition += movement;
            OnTranslate?.Invoke(_positionSpeed);
        }

        public void HandlerSetPositionXZ(Vector2 vector2) => _positionSpeed = new Vector3(vector2.x, 0, vector2.y);
    }
}
using UnityEngine;

namespace GameManager.Tools
{
    public sealed class RigidbodyRandomForce : MonoBehaviour
    {
        [SerializeField] private float _minForce = 5f;
        [SerializeField] private float _maxForce = 10f;

        [SerializeField] private Rigidbody[] _rigidbodies = new Rigidbody[] { };

        public void HandlerAddRandomForceXZ()
        {
            float forceX = 0;
            float forceZ = 0;

            foreach (Rigidbody rigidbody in _rigidbodies)
            {
                forceX = Random.Range(_minForce, _maxForce);
                forceZ = Random.Range(_minForce, _maxForce);

                Vector3 randomForce = new Vector3(Random.value > 0.5f ? forceX : -forceX, 0,Random.value > 0.5f ? forceZ : -forceZ);

                rigidbody.AddForce(randomForce, ForceMode.Impulse);
            }
        }
    }
}
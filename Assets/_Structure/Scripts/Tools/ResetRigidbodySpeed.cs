using UnityEngine;

namespace GameManager.Tools
{
    public sealed class ResetRigidbodySpeed : MonoBehaviour
    {
        [SerializeField] private Rigidbody[] _rigidbodies = new Rigidbody[] { };

        public void HandlerResetSpeed()
        {
            foreach (Rigidbody rigidbody in _rigidbodies)
            {
                rigidbody.detectCollisions = false;

                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
                
                rigidbody.Sleep();

                rigidbody.detectCollisions = true;
            }
        }
    }
}
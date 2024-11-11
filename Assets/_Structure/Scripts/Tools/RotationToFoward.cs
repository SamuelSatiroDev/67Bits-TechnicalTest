using UnityEngine;

namespace GameManager.Tools
{
    public sealed class RotationToFoward : MonoBehaviour
    {
        public void HandlerRotationToFoward(Vector3 vector3)
        {
            if (vector3 == Vector3.zero)
            {
                return;  
            }

            transform.forward = vector3;
        }
    }
}
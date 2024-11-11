using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformReset : MonoBehaviour
    {
        public void HandlerResetPositionRotation(Transform transform)
        {
            HandlerResetPosition(transform);
            HandlerResetRotation(transform);
        }
        public void HandlerResetPosition(Transform transform) => transform.localPosition = Vector3.zero;
        public void HandlerResetRotation(Transform transform) => transform.localRotation = Quaternion.identity;
        public void HandlerResetScale(Transform transform) => transform.localScale = Vector3.one;
    }
}
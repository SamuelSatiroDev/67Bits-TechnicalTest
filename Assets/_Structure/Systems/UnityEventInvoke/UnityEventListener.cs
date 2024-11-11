using UnityEngine;

namespace GameManager.UnityEventSystem
{
    public class UnityEventListener : MonoBehaviour
    {
        public void HandlerGetUnityEventInvoke(Transform transform)
        {
            transform.GetComponent<UnityEventInvoke>().HandlerInvoke();
        }
    }
}
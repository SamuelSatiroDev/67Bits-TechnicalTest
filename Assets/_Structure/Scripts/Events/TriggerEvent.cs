using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools.Events
{
    public sealed class TriggerEvent : MonoBehaviour
    {
        [SerializeField] private string [] _targetTags = new string[] {};
        public UnityEvent<Transform> OnTriggerEnterEvent;
        public UnityEvent<Transform> OnTriggerStayEvent;
        public UnityEvent<Transform> OnTriggerExitEvent;

        private void OnTriggerEnter(Collider other)
        {
            if (IsTagAllowed(other.tag) == false)
            {
                return;
            }

            OnTriggerEnterEvent?.Invoke(other.transform);
        }

        private void OnTriggerStay(Collider other)
        {
            if (IsTagAllowed(other.tag) == false)
            {
                return;
            }

            OnTriggerStayEvent?.Invoke(other.transform);
        }

        private void OnTriggerExit(Collider other)
        {
            if (IsTagAllowed(other.tag) == false)
            {
                return;
            }

            OnTriggerExitEvent?.Invoke(other.transform);
        }

        private bool IsTagAllowed(string tag)
        {
            bool isTagAllowed = _targetTags.Length <= 0 ? true : false;

            foreach (string targetTag in _targetTags)
            {
                if (tag.Equals(targetTag))
                {
                    isTagAllowed = true;
                }
            }

            return isTagAllowed;
        }
    }
}
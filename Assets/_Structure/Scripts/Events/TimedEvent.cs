using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace GameManager.Tools.Events
{
    public sealed class TimedEvent : MonoBehaviour
    {
        [SerializeField] private float _waitTime = 5f;

        [Space(10)]

        [SerializeField] private float _timerCount;

        public UnityEvent OnTimerComplete;

        public void HandlerStartTimer()
        {
            StopCoroutine(WaitAndTriggerEvent());
            StartCoroutine(WaitAndTriggerEvent());
        }

        private IEnumerator WaitAndTriggerEvent()
        {
            yield return new WaitForSeconds(_waitTime);

            OnTimerComplete.Invoke();
        }
    }
}
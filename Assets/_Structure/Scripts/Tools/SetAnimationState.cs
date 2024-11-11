using UnityEngine;

namespace GameManager.Tools
{
    public sealed class SetAnimationState : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        [Header("Read Only")]
        [SerializeField] private string _currentState;

        public void HandlerChangeAnimationState(string newState)
        {
            if (_currentState == newState)
            {
                return;
            }

            _animator.Play(newState);
            _currentState = newState;
        }
    }
}
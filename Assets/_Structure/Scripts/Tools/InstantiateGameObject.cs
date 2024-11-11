using UnityEngine;
using RageMachine.PoolingSystem;
using UnityEngine.Events;

namespace GameManager.Tools
{
    public sealed class InstantiateGameObject : MonoBehaviour
    {
        [SerializeField] private string _poolingID;
        [SerializeField] private short _defaultCapacity;
        [SerializeField] private short _maxSize;

        [Space(5)]

        [SerializeField] private Transform _prefab;
        [SerializeField] private Transform _content;

        [Space(10)]

        public UnityEvent<Transform> OnNewGameObject;

        public void HandlerInstantiate()
        {
            GameObject newGameObject = PoolingManager.HandlerOnGet(_poolingID, _prefab.gameObject, _content, _defaultCapacity, _maxSize); 
            if(newGameObject == null)
            {
                return;
            }

            newGameObject.transform.parent = _content;
            OnNewGameObject?.Invoke(newGameObject.transform);
        }
    }
}
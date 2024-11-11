using UnityEngine;

namespace GameManager.Tools
{
    /// <summary>
    /// Get a random position within a square. Can be used local position or position. 
    /// The changed position axes are X and Z.
    /// </summary>
    public sealed class RandomPositionInSquare : MonoBehaviour
    {
        [SerializeField] private float _size = 5f;
        [SerializeField] private Color _gizmosColor = Color.green; 

        public void HandlerGetRandomPosition(Transform transform)
        {
            float halfSize = _size / 2f;

            float randomX = Random.Range(this.transform.position.x - halfSize, this.transform.position.x + halfSize);
            float randomZ = Random.Range(this.transform.position.z - halfSize, this.transform.position.z + halfSize);

            transform.position = new Vector3(randomX, transform.position.y, randomZ);
        }

        public void HandlerGetRandomLocalPosition(Transform transform)
        {
            float halfSize = _size / 2f;

            float randomX = Random.Range(this.transform.position.x - halfSize, this.transform.position.x + halfSize);
            float randomZ = Random.Range(this.transform.position.z - halfSize, this.transform.position.z + halfSize);

            transform.localPosition = new Vector3(randomX, transform.position.y, randomZ);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = _gizmosColor;
            Vector3 center = transform.position;
            Gizmos.DrawWireCube(center, new Vector3(_size, 0, _size));
        }
    }
}
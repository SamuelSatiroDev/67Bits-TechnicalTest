using UnityEngine;

namespace GameManager.Tools
{
    public sealed class TransformStackChild : MonoBehaviour
    {
        [SerializeField] private Transform _contant;
        [SerializeField] private float _stackHeight = 1.0f;
        [SerializeField] private Vector2 _rateRange = new Vector2(0.8f, 0.8f);

        private void Update()
        {
            for (int i = 1; i < _contant.childCount; ++i)
            {
                float rate = Mathf.Lerp(_rateRange.x, _rateRange.y, (float)i / (float)_contant.childCount);
                _contant.GetChild(i).position = Vector3.Lerp(_contant.GetChild(i).position, _contant.GetChild(i - 1).position + (_contant.GetChild(i - 1).up * _stackHeight), rate);
                _contant.GetChild(i).rotation = Quaternion.Lerp(_contant.GetChild(i).rotation, _contant.GetChild(i -1).rotation, rate);
            }
        }
    }
}
using UnityEngine;

namespace GameManager.Tools
{
    public sealed class ApplicationQuit : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
#if UNITY_ANDROID || UNITY_IOS
                Application.Quit();
#endif
            }
        }
    }
}
using UnityEngine;

namespace RageMachine.Tools
{
    public sealed class SystemStartup : MonoBehaviour
    {
        public const string CONTROLLER_NAME = "SystemStartup";

        [RuntimeInitializeOnLoadMethod]
        static void OnRuntimeMethodLoad()
        {
            GameObject gameObject = new GameObject(CONTROLLER_NAME);
            gameObject.AddComponent<SystemStartup>();
            DontDestroyOnLoad(gameObject);
        }

        private void Awake()
        {
            Object getSystemStartup = Resources.Load(CONTROLLER_NAME);

            if(getSystemStartup == null)
            {
                return;
            }

            GameObject gameObject = Instantiate(getSystemStartup as GameObject, transform);
            gameObject.name = CONTROLLER_NAME;
        }
    }
}
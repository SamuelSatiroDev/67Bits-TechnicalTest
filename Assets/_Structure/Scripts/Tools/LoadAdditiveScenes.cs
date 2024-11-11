using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManager.Tools
{
    public sealed class LoadAdditiveScenes : MonoBehaviour
    {
        [SerializeField] private string[] _sceneNames = new string[] { };

        public void HandlerLoadScenesAdditively()
        {
            foreach (string sceneName in _sceneNames)
            {
                if (SceneManager.GetSceneByName(sceneName).isLoaded == false)
                {
                    SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
                }
            }
        }
    }
}
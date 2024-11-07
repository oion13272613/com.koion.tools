using UnityEngine;
using UnityEngine.SceneManagement;

namespace Koion
{
    /// <summary>
    /// 控制場景，載入場景、結束應用程式
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="_sceneName">載入的場景名稱</param>
        public void LoadScene(string _sceneName)
        {   
            SceneManager.LoadScene(_sceneName);
        }

        /// <summary>
        /// 結束應用程式
        /// </summary>
        public void QuitGame()
        {   
            Application.Quit();
        }
    }

}
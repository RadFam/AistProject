using UnityEngine;
using SystemManagers;

namespace History
{
    public class HistorySceneManager : MonoBehaviour
    {

        public void ReturnToMainScene()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.MainScene);
		}
    }
}
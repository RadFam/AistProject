using UnityEngine;
using SystemManagers;

namespace Minigame
{
    public class MinigameManager : MonoBehaviour
    {
        public void ReturnToMainScene()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.MainScene);
		}
    }
}
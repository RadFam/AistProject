using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SystemManagers;

namespace MainScene
{
    public class MainSceneManager : MonoBehaviour
    {

        public void OnHistoryPress()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.HistoryScene);
		}

		public void OnMinigamePress()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.MinigameScene);
		}

		public void OnPhotogalleryPress()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.PhotogalleryScene);
		}
    }
}
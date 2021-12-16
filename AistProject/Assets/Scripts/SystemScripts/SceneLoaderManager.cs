using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SystemManagers
{
    public class SceneLoaderManager : MonoBehaviour
    {
		public static SceneLoaderManager inst;

		public enum ScenesNames {EnterScene=4, MainScene=0, HistoryScene=1, PhotogalleryScene=3, MinigameScene=2};

		[SerializeField]
		int currentScene;
		[SerializeField]
		int sceneToLoad;

		public int CurrentScene
		{
			get {return currentScene;}
		}

		void Awake()
		{
			currentScene = 0;
			sceneToLoad = 0;
		}
        
        void Start()
        {
			if (inst == null)
			{
				inst = this;
			}
			else
			{
				Destroy(this.gameObject);
			}
        }

        public void LoadSceneByNum(int num)
		{
			sceneToLoad = num;
			StartCoroutine(LoadChosenScene());
		}

		public void LoadSceneByName(ScenesNames names)
		{
			sceneToLoad = (int)names;
			StartCoroutine(LoadChosenScene());
		}

		IEnumerator LoadChosenScene()
		{
			currentScene = sceneToLoad;
			AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(((ScenesNames)sceneToLoad).ToString("g"), LoadSceneMode.Single);
            while (!asyncLoad.isDone)
            {
                yield return null;
            }

			yield return null;
		}
    }
}
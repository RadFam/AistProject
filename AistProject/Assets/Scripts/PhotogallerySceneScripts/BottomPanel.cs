using UnityEngine;
using SystemManagers;

namespace Photogallery
{
    public class BottomPanel : MonoBehaviour
    {

        [SerializeField]
		GameObject homeButton;
		[SerializeField]
		GameObject balleryPanel;
		[SerializeField]
		PhotogalleryManager photogalleryManager;
		// Use this for initialization
        void Start()
        {
			
        }

        public void OnBushHomeBtn()
		{
			SceneLoaderManager.inst.LoadSceneByName(SceneLoaderManager.ScenesNames.MainScene);
		}

		public void OnPushNextMap()
		{
			photogalleryManager.OnShowNextMap();
		}
		public void OnPushPrevMap()
		{
			photogalleryManager.OnShowPrevMap();
		}

		public void OnPushExitMap()
		{
			ChangeBar(false);
		}

		public void ChangeBar(bool change)
		{
			if (change)
			{
				homeButton.SetActive(false);
				balleryPanel.SetActive(true);
			}
			else
			{
				balleryPanel.SetActive(false);
				homeButton.SetActive(true);
				photogalleryManager.OnShowButtons();
			}
		}
    }
}
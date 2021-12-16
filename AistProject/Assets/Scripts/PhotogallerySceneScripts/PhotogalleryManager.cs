using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SystemManagers;

namespace Photogallery
{
    public class PhotogalleryManager : MonoBehaviour
    {
        [SerializeField]
		PhotoButton photoButtonPrefab;
		[SerializeField]
		GameObject choosePhotoArea;
		[SerializeField]
		GameObject contentAreaBtn;
		[SerializeField]
		GameObject showMapArea;
		[SerializeField]
		GameObject contentAreaMap;
		[SerializeField]
		GameObject subbotomPanel;
		[SerializeField]
		Text mapName;

		int currentImg;

        void Start()
        {
			currentImg = -1;
			photoButtonPrefab.gameObject.SetActive(true);

			// Show all buttons
			int cnt = 0;
			foreach (WorldMapInfo wmi in GameManager.inst.worldMaps.mapData)
			{
				PhotoButton phB = Instantiate(photoButtonPrefab, contentAreaBtn.transform);
				phB.SetParams(wmi.subBtnMap, cnt++);
				phB.pushButton += OnShowWorldMap;
			}

			photoButtonPrefab.gameObject.SetActive(false);
        }

		public void OnShowButtons()
		{
			showMapArea.SetActive(false);
			subbotomPanel.SetActive(false);
			choosePhotoArea.SetActive(true);
		}

        public void OnShowWorldMap(int num)
		{
			currentImg = num;
			choosePhotoArea.SetActive(false);
			showMapArea.SetActive(true);
			subbotomPanel.SetActive(true);
			FindObjectOfType<BottomPanel>().ChangeBar(true);
			ShowMap();
		}

		public void OnShowNextMap()
		{
			currentImg += 1;
			if (currentImg == GameManager.inst.worldMaps.mapData.Count)
			{
				currentImg = 0;
			}
			ShowMap();
		}

		public void OnShowPrevMap()
		{
			currentImg -= 1;
			if (currentImg == -1)
			{
				currentImg = GameManager.inst.worldMaps.mapData.Count-1;
			}
			ShowMap();
		}

		void ShowMap()
		{
			contentAreaMap.GetComponent<Image>().sprite = GameManager.inst.worldMaps.mapData[currentImg].bigMap;
			mapName.text = GameManager.inst.worldMaps.mapData[currentImg].mainName;
		}
    }
}
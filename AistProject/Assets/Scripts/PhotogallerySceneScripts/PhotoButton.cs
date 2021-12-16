using System;
using UnityEngine;
using UnityEngine.UI;

namespace Photogallery
{
    public class PhotoButton : MonoBehaviour
    {
		public Action<int> pushButton;

		[SerializeField]
		Image frontImage;
		[SerializeField]
		int myInnerNum;
        // Use this for initialization
        void Start()
        {

        }

        public void SetParams(Sprite img, int num)
		{
			frontImage.sprite = img;
			myInnerNum = num;
		}

		public void OnPressButton()
		{
			pushButton(myInnerNum);
		}
    }
}
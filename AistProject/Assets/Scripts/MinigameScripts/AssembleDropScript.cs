using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GameUI
{
    public class AssembleDropScript : MonoBehaviour, IDropHandler
    {
		public string detailNeedName;
		public Vector3 detailSelfRotation;
		public Vector3 detailSelfScale;
        // Use this for initialization
        void Awake()
        {
        }

		public GameObject MyChild
        {
            get
            {

                if (gameObject.transform.childCount > 0)
                {
                    return gameObject.transform.GetChild(0).gameObject;
                }

                return null;
            }
        }

        public void OnDrop(PointerEventData eventData)
		{
			Debug.Log("Assemble name: " + gameObject.name);
			Debug.Log("MyChild: " + MyChild);
			if (!MyChild)
			{
				string dropItemName = DetailDragScript.dragItem.name;
				Debug.Log("dropItemName: " + dropItemName);
				if (dropItemName == detailNeedName)
				{
					DetailDragScript.dragItem.transform.SetParent(gameObject.transform);
					DetailDragScript.dragItem.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
					DetailDragScript.dragItem.transform.localScale = detailSelfScale;
					DetailDragScript.dragItem.transform.eulerAngles = detailSelfRotation;
				}
			}
		}
    }
}
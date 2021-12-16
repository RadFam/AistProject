using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GameUI
{
    public class DetailDragScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
		public static GameObject dragItem;
		Vector3 initPosition;
        Transform initParent;
        Transform rootParent;
        // Use this for initialization
        void Awake()
        {
        }

		public void OnBeginDrag(PointerEventData eventData)
        {
            dragItem = gameObject;
            initPosition = gameObject.transform.position;
            initParent = gameObject.transform.parent;
            rootParent = GameObject.Find("GameCanvas").transform;

            gameObject.transform.SetParent(rootParent); // Here alwas must be a canvas (transform.root)
            gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
        }

		public void OnDrag(PointerEventData eventData)
        {
            gameObject.transform.position = Input.mousePosition;
        }

		public void OnEndDrag(PointerEventData eventData)
        {
            //dragItem = null;

            if (gameObject.transform.parent == initParent || gameObject.transform.parent == rootParent) // gameObject.transform.root
            {
                gameObject.transform.position = initPosition;
                gameObject.transform.SetParent(initParent);
            }

            gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

    }
}
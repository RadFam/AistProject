using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemManagers
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager inst;

		public WorldMaps worldMaps;
        void Awake()
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

        // Update is called once per frame
        void Start()
        {
			worldMaps = Resources.Load<WorldMaps>("ScriptableObjects/WorldMaps");
        }
    }
}
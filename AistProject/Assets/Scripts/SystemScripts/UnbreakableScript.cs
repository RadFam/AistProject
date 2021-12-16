using UnityEngine;

namespace SystemManagers
{
    public class UnbreakableScript : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
			DontDestroyOnLoad(this.gameObject);
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenePos : MonoBehaviour
{

	public static Scene sceneLoaded;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
		sceneLoaded = SceneManager.GetActiveScene ();
    }

	void Start() {
		
	}

	void Update() {
		//sceneLoaded = SceneManager.GetActiveScene ();
		//Debug.Log (sceneLoaded.name);

	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (scenePos.sceneLoaded.name == "sala") {
			Debug.Log (scenePos.sceneLoaded.name);
			transform.position = new Vector3 (0, 1.5f, 2);
			transform.eulerAngles = new Vector3 (0, 90, 0);
		}
		if (scenePos.sceneLoaded.name == "corridoio") {
			Debug.Log (scenePos.sceneLoaded.name);
			transform.position = new Vector3 (0, 0, 0);
			transform.eulerAngles = new Vector3 (10, 20, 10);
		}
		if (scenePos.sceneLoaded.name == "camera1") {
			Debug.Log ("camera1");
			transform.position = new Vector3 (0, 0, 0);
			transform.eulerAngles = new Vector3 (10, 20, 10);
		}
		if (scenePos.sceneLoaded.name == "camera2") {
			Debug.Log ("camera2");
			transform.position = new Vector3 (0, 0, 0);
			transform.eulerAngles = new Vector3 (10, 20, 10);
		}
		if (scenePos.sceneLoaded.name == "bagno") {
			Debug.Log ("bagno");
			transform.position = new Vector3 (0, 0, 0);
			transform.eulerAngles = new Vector3 (10, 20, 10);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

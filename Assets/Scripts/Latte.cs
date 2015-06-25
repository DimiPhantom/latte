using UnityEngine;
using System.Collections;

public class Latte : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (Random.Range (-2.2f, 2.3f), 5.3f, 0);
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}

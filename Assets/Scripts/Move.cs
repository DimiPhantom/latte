using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x+0.2f*x,-1.03f,2.8f), -2.75f);
	}
}

using UnityEngine;
using System.Collections;

public class lattecontrol : MonoBehaviour {



	void Start () {
	
	}
	

	void Update () {

	}

	void OnTriggerEnter(Collider a)
	{
		a.GetComponent<SpriteRenderer> ().enabled = false;
		//Debug.Log (a.name);
	}

}

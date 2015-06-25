using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	GameObject chocolatte;

	// Use this for initialization
	void Start () {
		chocolatte = Resources.Load ("Prefab/chocolatte") as GameObject;
		StartCoroutine ("latte");
	}
	


	IEnumerator latte()
	{
		GameObject newlatte = Instantiate (chocolatte);
		yield return new WaitForSeconds (Random.Range(1.0f, 2.0f));
		
		StartCoroutine ("latte");

	}

}

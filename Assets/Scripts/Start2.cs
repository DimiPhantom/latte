using UnityEngine;
using System.Collections;

public class Start2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		StartCoroutine ("Fade");
	}
	IEnumerator Fade()
	{
		for (float i = 0; i <= 1; i += 0.005f) 
		{
			Color color = new Vector4 (1, 1, 1, i);
			transform.GetComponent<Renderer> ().material.color = color;
			yield return 0;
		}
		for(float i = 0; i<=1;i += 0.005f)
		{
			Color color = new Vector4(1,1,1,1-i);
			transform.GetComponent<Renderer>().material.color = color;
			yield return 0;
		}
		
		Application.LoadLevel ("Main");
	}
}

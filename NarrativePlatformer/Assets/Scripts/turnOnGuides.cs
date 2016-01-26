using UnityEngine;
using System.Collections;

public class turnOnGuides : MonoBehaviour {

	public GameObject InvisiGuides;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("hello");
		InvisiGuides.gameObject.SetActive(true);

	}
}

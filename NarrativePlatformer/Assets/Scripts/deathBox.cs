using UnityEngine;
using System.Collections;

public class deathBox : MonoBehaviour {
	public Transform character;
	private Vector3 respawn;
	// Use this for initialization
	void Start () {
		respawn = character.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		print ("something is there");
		if (other.gameObject.transform == character)
			character.position = respawn;
		else
			Destroy (other.gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {
	public Transform viewSphere;
	private Camera mainCam;
	private Vector3 spawnPoint;
	// Use this for initialization
	void Start () {
		mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			spawnPoint = mainCam.ScreenToWorldPoint(Input.mousePosition);
			spawnPoint.z = 0;
			Instantiate(viewSphere, spawnPoint, Quaternion.identity);
		}
	}
}

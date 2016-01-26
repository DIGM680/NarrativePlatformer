using UnityEngine;
using System.Collections;

public class birdControl : MonoBehaviour {
	public GameObject sphere;
	public GameObject bird;
	public GameObject roost;
	public float startScale =0.01f;
	public float finalScale = 1f;
	private float scaleStep;
	public float growRate = 0.1f;
	public float outSpeed = 0.2f;
	public float roostSpeed = 1.0f;
	private bool on = false;
	private Vector3 pos;
	void Start () {
		//spawns circle at shrunken size
		sphere.transform.localScale = new Vector3 (startScale, startScale, startScale);
	}
	
	void Update () {
		if (Input.GetMouseButton (0))
			on = true;
		else
			on = false;
		//scale circle to full size then stop
		if (on) {
			if (sphere.transform.localScale.x <= finalScale) {
				scaleStep = sphere.transform.localScale.x;
				scaleStep = scaleStep + growRate;
				//print (scaleStep + " , " + rate);
				sphere.transform.localScale = new Vector3 (scaleStep, scaleStep, scaleStep);
			}
			pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pos.z = 0;
			sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, pos, outSpeed);
			pos.z = pos.z-1.74f;
			bird.transform.position = Vector3.MoveTowards(bird.transform.position, pos, outSpeed);
		} 
		//reverse if not on
		else {
			if (sphere.transform.localScale.x >= startScale) {
				scaleStep = sphere.transform.localScale.x;
				scaleStep = scaleStep - growRate;
				sphere.transform.localScale = new Vector3 (scaleStep, scaleStep, scaleStep);
			}
			pos = roost.transform.position;
			sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, pos, roostSpeed);
			pos.z = pos.z-1.74f;
			bird.transform.position = Vector3.MoveTowards(bird.transform.position, pos, roostSpeed);
		}
	}
}

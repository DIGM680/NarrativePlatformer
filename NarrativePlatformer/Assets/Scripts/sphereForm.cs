using UnityEngine;
using System.Collections;

public class sphereForm : MonoBehaviour {
	public float finalScale = 1f;
	private float startScale =0.01f;
	private float scaleStep;
	public float rate = 0.1f;
	public Camera mainCam;
	private bool on = false;
	private Vector3 pos;
	void Start () {
		mainCam = Camera.main;
		//spawns circle at shrunken size
		this.transform.localScale = new Vector3 (startScale, startScale, startScale);
	}

	void Update () {
		if (Input.GetMouseButton (0))
			on = true;
		else
			on = false;
		//scale circle to full size then stop
		if (on) {
			if (this.transform.localScale.x <= finalScale) {
				scaleStep = this.transform.localScale.x;
				scaleStep = scaleStep + rate;
				//print (scaleStep + " , " + rate);
				this.transform.localScale = new Vector3 (scaleStep, scaleStep, scaleStep);
			}
		} 
		//reverse if not on
		else {
			if (this.transform.localScale.x >= startScale) {
				scaleStep = this.transform.localScale.x;
				scaleStep = scaleStep - rate;
				this.transform.localScale = new Vector3 (scaleStep, scaleStep, scaleStep);
			}
			else
				Destroy (this.gameObject);
		}
		pos = mainCam.ScreenToWorldPoint(Input.mousePosition);
		pos.z = 0;
		this.transform.position = pos;
	}
}

using UnityEngine;
using System.Collections;

public class characterScaler : MonoBehaviour {
	private Vector3 currentScale;
	private Vector3 startScale;
	private Vector3 endScale;
	public float distance;
	public float final;
	public float percentage = 1.0f;
	private float charHeight;
	// Use this for initialization
	void Start () {
		startScale = transform.localScale;
		currentScale = transform.localScale;
		endScale = transform.localScale * final;
	}

	// Update is called once per frame
	void Update () {
		charHeight = transform.position.y;
		if (charHeight >= 1.0f && charHeight < distance) {
			currentScale = startScale * (percentage/charHeight);
			if (currentScale.x > startScale.x)
				currentScale = startScale;
			if (currentScale.x < endScale.x)
				currentScale = endScale;
			transform.localScale = currentScale;
		}
		else if (charHeight < 1.0f) {
			currentScale = startScale;
			transform.localScale = currentScale;
		}
		else if (charHeight < 1.0f) {
			currentScale = endScale;
			transform.localScale = currentScale;
		}
	}
}

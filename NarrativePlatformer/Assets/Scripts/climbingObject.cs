using UnityEngine;
using System.Collections;

public class climbingObject : MonoBehaviour {
	public GameObject character;
	private Vector3 currentPos;
	private float startPos;
	private float endPos;
	public float distance;
	public float percentage = 1.0f;
	private float charHeight;
	// Use this for initialization
	void Start () {
		startPos = transform.position.y;
		currentPos = transform.position;
		endPos = transform.position.y + distance;
	}
	
	// Update is called once per frame
	void Update () {
		charHeight = character.transform.position.y;
		if (charHeight >= 1.0f && charHeight <= distance) {
			currentPos.y = startPos + (charHeight * percentage);
			transform.position = currentPos;
		}
		else if (charHeight > distance) {
			currentPos.y = endPos;
			transform.position = currentPos;
		}
		else if (charHeight < 1.0f) {
			currentPos.y = startPos;
			transform.position = currentPos;
		}
	}
}

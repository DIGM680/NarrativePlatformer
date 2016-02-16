using UnityEngine;
using System.Collections;

public class timedWallDestroyer : MonoBehaviour {
	public triggerController target;
	public int limit = 10;
	public int timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target.active)
			timer++;
		if (timer > limit)
			Destroy (this.gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class timedWallDestroyer : MonoBehaviour {
	public triggerController target;
	public int limit = 10;
	public int timer = 0;
	private AudioSource doorSound;
	private float endRot;
	private float step = 1f;
	private BoxCollider2D collider;
    private bool played = false;
	// Use this for initialization
	void Start () {
		doorSound = GetComponent<AudioSource> ();
		collider = GetComponent<BoxCollider2D> ();
		endRot = transform.localRotation.y + 90f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target.active)
			timer++;
		if (timer > limit) {
            if (!doorSound.isPlaying && !played)
            {
                doorSound.Play();
                played = true;
            }
			collider.enabled = false;
			Quaternion newRot = transform.localRotation;
			if (newRot.y >= endRot)
				return;
			newRot.y = newRot.y + step;
			transform.localRotation = newRot;
            if (!doorSound.isPlaying && !played)
            {
                doorSound.Play();
                played = true;
            }
            //Destroy (this.gameObject);
        }
	}
}

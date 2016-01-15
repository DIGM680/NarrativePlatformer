using UnityEngine;
using System.Collections;

public class triggerController : MonoBehaviour {
	private bool active = false;
	public bool sound = false;
	private AudioSource soundSource;
	public bool instantiate = false;
	public Transform spawn;
	private int timer = 0;
	public int spawnTime = 40;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		if (sound)
			soundSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (sound && active) 
		    if(!soundSource.isPlaying)
				soundSource.Play ();
		if (sound && !active)
			soundSource.Pause ();
	}
	void FixedUpdate () {
		if (instantiate && active) {
			timer = timer + 1;
			if (timer >= spawnTime) {
				timer = 0;
				pos = transform.position;
				pos.z = -3f;
				Instantiate (spawn, pos, Quaternion.identity);
			}
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.layer == LayerMask.NameToLayer("viewSphere")){
			active = true;
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.layer == LayerMask.NameToLayer ("viewSphere")) {
			active = false;
		}
	}
}

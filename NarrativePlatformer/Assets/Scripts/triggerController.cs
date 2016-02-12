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

    public bool justOnce = false;
    [SerializeField]private bool completed = false;

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

		if (instantiate && active && !completed) {
			timer = timer + 1;
			if (timer >= spawnTime) {
				timer = 0;
				pos = transform.position;
				pos.z = -3f;
				Instantiate (spawn, pos, Quaternion.identity);

                if (justOnce)
                {
                    completed = true;
                }
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

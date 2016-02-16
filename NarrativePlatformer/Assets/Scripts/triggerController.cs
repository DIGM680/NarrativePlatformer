using UnityEngine;
using System.Collections;

public class triggerController : MonoBehaviour {
	public bool active = false;
	public bool sound = false;
	public bool particle = false;
	private ParticleSystem partSource;
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
		if (particle) {
			partSource = GetComponent<ParticleSystem> ();
			var em = partSource.emission;
			em.enabled = false;
		}
		if (sound)
			soundSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (sound && active) 
		    if(!soundSource.isPlaying)
				soundSource.Play ();
		else if (sound && !active)
			soundSource.Pause ();
		if (particle && active){
			var em = partSource.emission;
			em.enabled = true;
		}
		else if (particle && !active){
			var em = partSource.emission;
			em.enabled = false;
		}
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

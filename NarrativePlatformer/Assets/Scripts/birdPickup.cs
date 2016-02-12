using UnityEngine;
using System.Collections;

public class birdPickup : MonoBehaviour {
    public string name;
	public GameObject bird;
	public GameObject physics;
	public bool click;
	public bool attached;
	private Vector3 temPos;

    public GameObject viewPort;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))
			click = true;
		if (Input.GetMouseButtonUp(0)) {
			click = false;
			attached = false;
			temPos = physics.transform.position;
			temPos.z = 0f;
			physics.transform.position = temPos;
		}

        AttachAndClickecked();
	}
	void OnTriggerEnter(Collider other) {
		if ((other.gameObject.layer == LayerMask.NameToLayer("viewSphere")) && click){

			attached = true;

		}
	}

    void AttachAndClickecked() {
        if (attached && click)
        {
            temPos = bird.transform.position;
            temPos.z = temPos.z - 1.74f;
            //transform.position = temPos;
            physics.transform.position = temPos;
            //physics.transform.position = Vector3.MoveTowards(physics.transform.position, temPos, 0.2f);
            viewPort.layer = LayerMask.NameToLayer(name);
        }
        else { viewPort.layer = LayerMask.NameToLayer("viewSphere"); }
    }
}

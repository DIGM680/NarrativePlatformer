using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class slide : MonoBehaviour {

    public List<GameObject> rocks;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D Player)
    {
        foreach (GameObject rock in rocks) {
            Rigidbody2D rigidBody = rock.GetComponent<Rigidbody2D>();
            rigidBody.isKinematic = false;
            }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class slide : MonoBehaviour {

    public List<GameObject> rocks;
    private  AudioSource audio;
    private bool rocksFallen;
    
	// Use this for initialization
	void Start () {
	audio = GetComponent<AudioSource>();
        rocksFallen = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.layer == LayerMask.NameToLayer("character") && rocksFallen == false)
        {
            foreach (GameObject rock in rocks)
            {
                Rigidbody2D rigidBody = rock.GetComponent<Rigidbody2D>();
                rigidBody.isKinematic = false;
            }
        }
        
        audio.Play();

        rocksFallen = true;
    }
}

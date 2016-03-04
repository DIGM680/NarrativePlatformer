using UnityEngine;
using System.Collections;

public class showTrigger : MonoBehaviour {

    public GameObject obj;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.layer == LayerMask.NameToLayer("character"))
        {
            obj.SetActive(true);
        }
    }
}

using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    Transform shell;
    public int triggerCount = 0;

	// Use this for initialization
	void Start () {
        shell = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("apple") && triggerCount <4)
        {
            triggerCount += 1;
            Rotate30();
        }
        
        Debug.Log("Collied");
    }

    void Rotate30() {
        shell.Rotate(Vector3.forward, -20f);
    }
}

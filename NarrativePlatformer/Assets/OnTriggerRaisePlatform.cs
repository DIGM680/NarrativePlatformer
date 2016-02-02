using UnityEngine;
using System.Collections;

public class OnTriggerRaisePlatform : MonoBehaviour {

    public int triggerCount;

    // Use this for initialization
    void Start() {

    }
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pearl"))
        {

        }


    }

}

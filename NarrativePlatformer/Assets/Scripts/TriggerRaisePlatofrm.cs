using UnityEngine;
using System.Collections;

public class TriggerRaisePlatofrm : MonoBehaviour {
    private int triggerCount;
    public GameObject platform;
    public float trnaformUp;

    // Use this for initialization
    void Start () {
        triggerCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pearl") && triggerCount < 2) {
            Debug.Log("it's a pearl");
        }
        Debug.Log("statue responded");
        platform.transform.position = new Vector3(20, -27,0);
    }
}

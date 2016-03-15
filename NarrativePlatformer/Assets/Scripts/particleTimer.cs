using UnityEngine;
using System.Collections;

public class particleTimer : MonoBehaviour {

    private float timer;
    public float level1HintTime;
    public bool doorOpened;
    
	// Use this for initialization
	void Start () {
	   
        timer=0.0f;
        
	}
	
	// Update is called once per frame
	void Update () {
        
	   if (timer < level1HintTime){
        timer ++;
        } else if (doorOpened = false){
          GetComponent<ParticleSystem>().Play();
        } else {
          GetComponent<ParticleSystem>().Stop();
       }
           
	}
}

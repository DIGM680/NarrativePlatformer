using UnityEngine;
using System.Collections;

public class platformRevealer : MonoBehaviour {

    private bool active = false;
    public bool justOnce = false;
    [SerializeField]
    private bool completed = false;
    private AudioSource audio;

    public GameObject obj;

    void Start()
    {
        obj.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {

        if (active && !completed)
        {
            obj.SetActive(true);

            audio.Play();

            if (justOnce)
            {
                completed = true;
            }

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("viewSphere"))
        {
            active = true;
        }
    }
}
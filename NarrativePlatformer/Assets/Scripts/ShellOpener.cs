using UnityEngine;
using System.Collections;

public class ShellOpener : MonoBehaviour {

    public GameObject upperShell;
    public GameObject pearlIn;
    private bool active = false;
    public bool justOnce = false;
    [SerializeField]
    private bool completed = false;
    private AudioSource audio;

    public GameObject obj;
    public GameObject obj2;

    void Start()
    {
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
            upperShell.transform.Rotate(Vector3.forward, -20f);

            pearlIn.SetActive(true);

            obj.SetActive(true);
            obj2.SetActive(true);

            audio.Play();

            if (justOnce)
            {
                completed = true;
            }

        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("drop"))
        {
            Debug.Log("Shell Triggered.");
            active = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("drop"))
        {
            active = false;
        }
    }
}

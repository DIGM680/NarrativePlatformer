using UnityEngine;
using System.Collections;

public class ShellOpener : MonoBehaviour {

    public GameObject upperShell;
    public GameObject pearlIn;
    private bool active = false;
    public bool justOnce = false;
    [SerializeField]
    private bool completed = false;

    void Start()
    {
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

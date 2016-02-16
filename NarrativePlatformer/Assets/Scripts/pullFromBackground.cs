using UnityEngine;
using System.Collections;

public class pullFromBackground : MonoBehaviour {

    public GameObject backgroundObject;
    public Transform spawn;

    public bool instantiate = false;

    private Vector3 pos;
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

        if (instantiate && active && !completed)
        {

            pos = transform.position;
            pos.z = -3f;
            Instantiate(spawn, pos, Quaternion.identity);
            backgroundObject.SetActive(false);

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
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("viewSphere"))
        {
            active = false;
        }
    }
}

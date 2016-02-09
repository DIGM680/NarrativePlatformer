using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

    public float frontOfPlayer;

    public bool bounds;

    public GameObject player;

    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

	// Use this for initialization
	void Start () {
        Debug.Log(player.transform);
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate() {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x+frontOfPlayer, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);

        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),
                                                Mathf.Clamp(transform.position.y,minCameraPos.y, maxCameraPos.y),
                                                Mathf.Clamp(transform.position.z,minCameraPos.z,maxCameraPos.z));
        }
    }
}
